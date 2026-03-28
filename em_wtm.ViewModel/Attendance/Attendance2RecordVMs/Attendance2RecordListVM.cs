using em_wtm.Model._Business.Attendance;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;


namespace em_wtm.ViewModel.Attendance.Attendance2RecordVMs
{
    public partial class Attendance2RecordListVM : BasePagedListVM<Attendance2Record_View, Attendance2RecordSearcher>
    {

        protected override IEnumerable<IGridColumn<Attendance2Record_View>> InitGridHeader()
        {
            return new List<GridColumn<Attendance2Record_View>>{
                this.MakeGridHeader(x => x.EmployeeName_view),
                this.MakeGridHeader(x => x.PeriodNo),
                this.MakeGridHeader(x => x.SDate),
                this.MakeGridHeader(x => x.BAttTime),
                this.MakeGridHeader(x => x.EAttTime),
                this.MakeGridHeader(x => x.BOffset),
                this.MakeGridHeader(x => x.EOffset),
                this.MakeGridHeader(x => x.BOffsetFee),
                this.MakeGridHeader(x => x.EOffsetFee),
                this.MakeGridHeader(x => x.DayTypeName_view),
                this.MakeGridHeader(x => x.PlanName_view),
                this.MakeGridHeader(x => x.ClassName_view),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Attendance2Record_View> GetSearchQuery()
        {
            var query = DC.Set<Attendance2Record>()
                .CheckEqual(Searcher.EmployeeId, x => x.EmployeeId)
                .CheckBetween(Searcher.SDate?.GetStartTime(), Searcher.SDate?.GetEndTime(), x => x.SDate, includeMax: false)
                .Select(x => new Attendance2Record_View
                {
                    ID = x.ID,
                    EmployeeName_view = x.Employee.EmployeeName,
                    PeriodNo = x.PeriodNo,
                    SDate = x.SDate,
                    BAttTime = x.BAttTime,
                    EAttTime = x.EAttTime,
                    BOffset = x.BOffset,
                    EOffset = x.EOffset,
                    BOffsetFee = x.BOffsetFee,
                    EOffsetFee = x.EOffsetFee,
                    DayTypeName_view = x.DayType.DayTypeName,
                    PlanName_view = x.Plan.PlanName,
                    ClassName_view = x.Class.ClassName,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Attendance2Record_View : Attendance2Record
    {
        [Display(Name = "员工姓名")]
        public String EmployeeName_view { get; set; }
        [Display(Name = "日期类型名称")]
        public String DayTypeName_view { get; set; }
        [Display(Name = "计划名")]
        public String PlanName_view { get; set; }
        [Display(Name = "班次名")]
        public String ClassName_view { get; set; }

    }
}
