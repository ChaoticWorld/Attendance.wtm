using em_wtm.Model._Business.Attendance;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;


namespace em_wtm.ViewModel.Attendance.Attendance2PlanRefClassVMs
{
    public partial class Attendance2PlanRefClassListVM : BasePagedListVM<Attendance2PlanRefClass_View, Attendance2PlanRefClassSearcher>
    {

        protected override IEnumerable<IGridColumn<Attendance2PlanRefClass_View>> InitGridHeader()
        {
            return new List<GridColumn<Attendance2PlanRefClass_View>>{
                this.MakeGridHeader(x => x.ID),
                this.MakeGridHeader(x => x.ClassName_view),
                this.MakeGridHeader(x => x.PlanName_view),
                this.MakeGridHeader(x => x.PeriodNo),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Attendance2PlanRefClass_View> GetSearchQuery()
        {
            var query = DC.Set<Attendance2PlanRefClass>()
                .CheckEqual(Searcher.ClassId, x => x.ClassId)
                .CheckEqual(Searcher.PlanId, x => x.PlanId)
                .Select(x => new Attendance2PlanRefClass_View
                {
                    ID = x.ID,
                    ClassName_view = x.Class.ClassName,
                    PlanName_view = x.Plan.PlanName,
                    PeriodNo = x.PeriodNo,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Attendance2PlanRefClass_View : Attendance2PlanRefClass
    {
        [Display(Name = "班次名")]
        public String ClassName_view { get; set; }
        [Display(Name = "计划名")]
        public String PlanName_view { get; set; }

    }
}
