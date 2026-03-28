using em_wtm.Model._Business.Attendance;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2FeeCalculatorVMs
{
    public partial class Attendance2FeeCalculatorListVM : BasePagedListVM<Attendance2FeeCalculator_View, Attendance2FeeCalculatorSearcher>
    {

        protected override IEnumerable<IGridColumn<Attendance2FeeCalculator_View>> InitGridHeader()
        {
            return new List<GridColumn<Attendance2FeeCalculator_View>>{
                this.MakeGridHeader(x => x.DayTypeName_view),
                this.MakeGridHeader(x => x.RangeA),
                this.MakeGridHeader(x => x.RangeB),
                this.MakeGridHeader(x => x.RangePrice),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Attendance2FeeCalculator_View> GetSearchQuery()
        {
            var query = DC.Set<Attendance2FeeCalculator>()
                .Select(x => new Attendance2FeeCalculator_View
                {
                    ID = x.ID,
                    DayTypeName_view = x.DayType.DayTypeName,
                    RangeA = x.RangeA,
                    RangeB = x.RangeB,
                    RangePrice = x.RangePrice,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Attendance2FeeCalculator_View : Attendance2FeeCalculator
    {
        [Display(Name = "日期类型名称")]
        public String DayTypeName_view { get; set; }

    }
}
