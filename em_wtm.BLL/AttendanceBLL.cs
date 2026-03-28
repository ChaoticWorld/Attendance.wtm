using em_wtm.BLL.DingTalkDFL;
using em_wtm.Model._Business.Attendance;
using WalkingTec.Mvvm.Core;

namespace em_wtm.BLL
{
    public class AttendanceBLL
    {

        public async Task<List<Attendance2Record>?> getDingTalkAttendance(AttendanceSearchModel searchModel)
        {
            List<Attendance2Record> AttendanceRecords = new List<Attendance2Record>();
            DingTalkAttendance dingTalkAttendance = new DingTalkAttendance();
            Attendance2Record record = new Attendance2Record();
            try
            {
                foreach (VAttendanceEmployee emp in searchModel.AttendanceEmployees)
                {
                    List<DingTalkAttendanceRecord>? dingTalkAttes = await dingTalkAttendance.getUserCheckTime(emp.EmployeeName, searchModel.DateTimeRange);
                    if (dingTalkAttes == null) continue;
                    foreach (DateTime date in DateRange2Enumerable(searchModel.DateTimeRange))
                    {
                        var dtRecords = dingTalkAttes.FindAll(f => f.workDateTime == date);
                        if (dtRecords != null && dtRecords.Count > 0)
                        {
                            record = new Attendance2Record()
                            {
                                Employee = emp,
                                EmployeeId = emp.ID,
                                SDate = date,
                                BAttTime = dtRecords.Select(s => s.userCheckDateTime).Min().TimeOfDay,
                                EAttTime = dtRecords.Select(s => s.userCheckDateTime).Max().TimeOfDay
                            };

                            AttendanceRecords.Add(record);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return AttendanceRecords;
        }
        public IEnumerable<DateTime> DateRange2Enumerable(DateRange dateRange)
        {
            for (var day = dateRange.GetStartTime().Value.Date; day.Date <= dateRange.GetEndTime().Value.Date; day = day.AddDays(1))
                yield return day;
        }
    }
    public class AttendanceSearchModel
    {
        public DateRange? DateTimeRange { get; set; }
        public List<VAttendanceEmployee>? AttendanceEmployees { get; set; }
    }
}