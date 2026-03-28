using em_wtm.Model._Business.Attendance;
using System.Collections.Generic;
using System.Linq;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;

namespace em_wtm.ViewModel.Attendance.VAttendanceReportVMs
{
    public partial class VAttendanceReportListVM : BasePagedListVM<VAttendanceReport_View, VAttendanceReportSearcher>
    {
        //protected override List<GridAction> InitGridAction()
        //{
        //    //增加功能按钮
        //    var importFromDevice = this.MakeAction("VAttendanceReport", "ImportFromDevice", "导入考勤", "导入设备考勤", GridActionParameterTypesEnum.SingleId, "Attendance");
        //    List<GridAction> actions = base.InitGridAction(); 
        //    actions.Add(importFromDevice);
        //    return actions;
        //}
        protected override IEnumerable<IGridColumn<VAttendanceReport_View>> InitGridHeader()
        {
            return new List<GridColumn<VAttendanceReport_View>>{
                this.MakeGridHeader(x => x.SDate),
                this.MakeGridHeader(x => x.Description),
                this.MakeGridHeader(x => x.BAttTime),
                this.MakeGridHeader(x => x.BOffset),
                //.SetFormat(
                    //(a,b)=>ColumnFormatInfo.MakeButton(buttonType:ButtonTypesEnum.Link,"/Attendance/AttendaceEventDeclared/",a.BOffset?.ToString(),500,null,"考勤事件")
                    //),
                this.MakeGridHeader(x => x.EAttTime),
                this.MakeGridHeader(x => x.EOffset),
                this.MakeGridHeader(x => x.Event),
                this.MakeGridHeader(x => x.Fee),
                this.MakeGridHeader(x => x.bOffsetFee),
                this.MakeGridHeader(x=>x.eOffsetFee),
                this.MakeGridHeader(x=>x.EmployeeId)
                //this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<VAttendanceReport_View> GetSearchQuery()
        {//bug:Searcher.SDate 结束日期不正确
            var query = DC.Set<VAttendanceReport>()
                .CheckEqual(Searcher.EmployeeId, x => x.EmployeeId);
            if (Searcher.SDate != null)
            {
                query = query.Where(x => x.SDate >= Searcher.SDate.GetStartTime())
                    .Where(x => x.SDate < Searcher.SDate.GetEndTime());
                //上面Where，日期条件 参数化，查询不报错。
                //query = query.CheckBetween(Searcher.SDate.GetStartTime(), Searcher.SDate.GetEndTime(), x => x.SDate);
                //上面CheckBetween日期条件 直接写入SQL语句，SQL执行报日期格式错误
            }
            var query1 = query.Select(x => new VAttendanceReport_View
            {
                ID = x.ID,
                SDate = x.SDate,
                Description = x.Description,
                BAttTime = x.BAttTime,
                BOffset = x.BOffset,
                EAttTime = x.EAttTime,
                EOffset = x.EOffset,
                Event = x.Event,
                bOffsetFee = x.bOffsetFee,
                eOffsetFee = x.eOffsetFee,
                Fee = x.Fee,
                EmployeeId = x.EmployeeId
            })
            .OrderBy(x => x.ID).OrderBy(x => x.SDate);
            return query1;
        }

    }

    public class VAttendanceReport_View : VAttendanceReport
    {
        public string ApprovalEmpty { get; set; } = string.Empty;

    }
}
