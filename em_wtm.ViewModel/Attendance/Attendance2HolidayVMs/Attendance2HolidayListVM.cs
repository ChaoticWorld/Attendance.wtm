using em_wtm.Model._Business.Attendance;
using System.Collections.Generic;
using System.Linq;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;


namespace em_wtm.ViewModel.Attendance.Attendance2HolidayVMs
{
    public partial class Attendance2HolidayListVM : BasePagedListVM<Attendance2Holiday_View, Attendance2HolidaySearcher>
    {

        protected override IEnumerable<IGridColumn<Attendance2Holiday_View>> InitGridHeader()
        {
            return new List<GridColumn<Attendance2Holiday_View>>{
                this.MakeGridHeader(x => x.IYear),
                this.MakeGridHeader(x => x.SDate),
                this.MakeGridHeader(x => x.SName),
                this.MakeGridHeader(x => x.SDescription),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Attendance2Holiday_View> GetSearchQuery()
        {
            var query = DC.Set<Attendance2Holiday>()
                .CheckEqual(Searcher.IYear, x => x.IYear)
                .CheckContain(Searcher.SName, x => x.SName)
                .CheckContain(Searcher.SDescription, x => x.SDescription)
                .Select(x => new Attendance2Holiday_View
                {
                    ID = x.ID,
                    IYear = x.IYear,
                    SDate = x.SDate,
                    SName = x.SName,
                    SDescription = x.SDescription,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Attendance2Holiday_View : Attendance2Holiday
    {

    }
}
