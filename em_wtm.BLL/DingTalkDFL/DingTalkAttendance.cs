using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;
using DingTalkDFL;
using WalkingTec.Mvvm.Core;

namespace em_wtm.BLL.DingTalkDFL
{
    public class DingTalkAttendance : DingTalkBase
    {
        public List<OapiUserSimplelistResponse.UserlistDomain> userLists { get; private set; } = new List<OapiUserSimplelistResponse.UserlistDomain>();
        public List<OapiDepartmentListResponse.DepartmentDomain> departmentLists { get; private set; } = new List<OapiDepartmentListResponse.DepartmentDomain>();
        public DingTalkAttendance()
        {
            getAtteUsers();
            #region ConsoleTest
            /* !Console Test!
            var departments = getDepartments();
            Console.WriteLine("选择部门：");
            foreach (var d in departments) {
                Console.WriteLine(string.Format("{0} - {1}", d.Id.ToString(), d.Name));
            }
            string depId = Console.ReadLine();
            long lDepId = long.Parse(depId);
            var Users = getUsers(lDepId);
            List<string> userIdList = new List<string>();
            foreach (var u in Users) {
                Console.WriteLine(string.Format("{0} - {1}", u.Userid, u.Name));
                userIdList.Add(u.Userid);
            }

            Console.WriteLine("部门员工考勤：");

            var attendances = getAttendances(userIdList);
            foreach (var att in attendances) {
                Console.WriteLine(string.Format("员工信息：{0} - {1}", att.UserId, Users.Find(f => f.Userid == att.UserId).Name));
                Console.Write(att.WorkDate + "\t"); Console.WriteLine(new DateTime(long.Parse(att.WorkDate) * 10000 + 621356256000000000).ToString());
                Console.WriteLine(att.CheckType);
                Console.WriteLine(att.TimeResult);
                Console.Write(att.BaseCheckTime + "\t"); Console.WriteLine(new DateTime(long.Parse(att.BaseCheckTime) * 10000 + 621356256000000000).ToString());
                Console.Write(att.UserCheckTime + "\t"); Console.WriteLine(new DateTime(long.Parse(att.UserCheckTime) * 10000 + 621356256000000000).ToString());

            }
            Console.WriteLine("Over!");
            Console.ReadLine();
        */
            #endregion
        }
        public async void getAtteUsers()
        {
            departmentLists = new List<OapiDepartmentListResponse.DepartmentDomain>();
            userLists = new List<OapiUserSimplelistResponse.UserlistDomain>();
            var deps = await getDepartments();
            var atteGroup = await getAtteGroup();
            foreach (var depName in atteGroup.DeptNameList)
            {
                departmentLists.Add(deps.First(f => f.Name == depName));
            }

            foreach (var dep in departmentLists)
            {
                userLists.AddRange(await getUsers(dep.Id));
            }
        }

        public async Task<OapiAttendanceGetsimplegroupsResponse.AtGroupForTopVoDomain> getAtteGroup()
        {
            DefaultDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/topapi/attendance/getsimplegroups");
            OapiAttendanceGetsimplegroupsRequest request = new OapiAttendanceGetsimplegroupsRequest();
            OapiAttendanceGetsimplegroupsResponse response = client.Execute(request, token);
            var attes = response.Result;
            var atteGroup = attes.Groups.First(f => f.GroupName == "考勤组");
            return atteGroup;
        }

        public async Task<List<OapiAttendanceListResponse.RecordresultDomain>> getAttendances(DateRange dateRange, List<string> userIdList)
        {
            List<OapiAttendanceListResponse.RecordresultDomain> recordresults = new List<OapiAttendanceListResponse.RecordresultDomain>();
            IDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/attendance/list");
            OapiAttendanceListRequest request = new OapiAttendanceListRequest();
            OapiAttendanceListResponse response;

            int userIdListSectionCount = userIdList.Count / 50 + (userIdList.Count % 50 > 0 ? 1 : 0);
            for (int i = 0; i < userIdListSectionCount; i++)
            {
                var UserIds = userIdList.GetRange(50 * i, userIdList.Count - 50 * i >= 50 ? 50 : userIdList.Count - 50 * i);

                request.UserIdList = UserIds;
                DateTime start = dateRange.GetStartTime().Value.Date;
                DateTime end = dateRange.GetEndTime().Value.Date;

                do
                {
                    request.WorkDateFrom = string.Format("{0}-{1}-{2} 00:00:00", start.Year, start.Month, start.Day);
                    request.WorkDateTo = string.Format("{0}-{1}-{2} 00:00:00", start.Year, start.Month,
                        end.Subtract(start).Days < 7 ? end.Day : start.Day + 7);
                    int exeCount = request.UserIdList.Count * 7 * 2;
                    int jCount = (int)Math.Ceiling(exeCount / 50.00);
                    for (int j = 0; j < jCount; j++)
                    {
                        request.Offset = j * 50;
                        request.Limit = 50;

                        response = client.Execute(request, token);
                        if (response.Recordresult != null)
                            recordresults.AddRange(response.Recordresult);
                    }
                    start = start.AddDays(7);
                } while (start < end);
            }
            return recordresults;
        }

        public async Task<List<OapiUserSimplelistResponse.UserlistDomain>> getUsers(long deparmentId)
        {
            IDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/simplelist");
            OapiUserSimplelistRequest request = new OapiUserSimplelistRequest();
            request.DepartmentId = deparmentId;
            request.Offset = 0;
            request.Size = 100;
            request.SetHttpMethod("GET");

            OapiUserSimplelistResponse response = client.Execute(request, token);

            //Console.WriteLine(response.Body);
            //Console.ReadLine();
            return response.Userlist;
        }


        public async Task<List<OapiDepartmentListResponse.DepartmentDomain>> getDepartments()
        {
            IDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/department/list");
            OapiDepartmentListRequest req = new OapiDepartmentListRequest();
            req.SetHttpMethod("GET");
            OapiDepartmentListResponse res = client.Execute(req, token);
            //Console.WriteLine(res.Body);
            //Console.ReadLine();
            return res.Department;
        }

        public async Task<List<DingTalkAttendanceRecord>?> getUserCheckTime(string empName, DateRange dateRange)
        {
            var DingtalkAttendanceEmployee = userLists.FirstOrDefault(f => f.Name == empName, null);
            if (DingtalkAttendanceEmployee is null) return null;
            string userId = DingtalkAttendanceEmployee.Userid;
            var attes = await getAttendances(dateRange, new List<string>() { userId });
            if (attes == null || attes.Count <= 0) return null;
            //DateTimeRange dateTimeRange
            List<DingTalkAttendanceRecord> result = new List<DingTalkAttendanceRecord>();
            foreach (var att in attes)
            {
                if (att.TimeResult != "NotSigned")
                {
                    DingTalkAttendanceRecord dtRecord = ClsHelper.ClsHelper.CopyFromParent<OapiAttendanceListResponse.RecordresultDomain, DingTalkAttendanceRecord>(att);
                    dtRecord.userCheckDateTime = GetDateTime(att.UserCheckTime);
                    dtRecord.workDateTime = GetDateTime(att.WorkDate);
                    result.Add(dtRecord);
                }
            }
            return result;
        }
    }
    public class DingTalkAttendanceRecord : OapiAttendanceListResponse.RecordresultDomain
    {
        public DateTime userCheckDateTime { get; set; }
        public DateTime workDateTime { get; set; }
    }
}
