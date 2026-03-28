using em_wtm.Model._Business.Attendance;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;


namespace em_wtm.ViewModel.Attendance.Attendance2PlanTimeVMs
{
    public partial class Attendance2PlanTimeListVM : BasePagedListVM<Attendance2PlanTime_View, Attendance2PlanTimeSearcher> {

        protected override IEnumerable<IGridColumn<Attendance2PlanTime_View>> InitGridHeader() {
            return new List<GridColumn<Attendance2PlanTime_View>>{
                this.MakeGridHeader(x => x.PlanName),
                this.MakeGridHeader(x => x.DayTypeName_view),
                this.MakeGridHeader(x => x.Description),
                this.MakeGridHeader(x => x.BTime),
                this.MakeGridHeader(x => x.ETime),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Attendance2PlanTime_View> GetSearchQuery() {
            var query = DC.Set<Attendance2PlanTime>()
                .CheckContain(Searcher.PlanName, x => x.PlanName)
                .CheckContain(Searcher.Description, x => x.Description)
                .Select(x => new Attendance2PlanTime_View {
                    ID = x.ID,
                    PlanName = x.PlanName,
                    DayTypeName_view = x.DayType.DayTypeName,
                    Description = x.Description,
                    BTime = x.BTime,
                    ETime = x.ETime
                })
                .OrderBy(x => x.ID);
            //var qresult = query.ToList();
            return query;
        }
    }

    public class Attendance2PlanTime_View : Attendance2PlanTime
    {
        [Display(Name = "日期类型名称")]
        public String DayTypeName_view { get; set; }

    }
}
