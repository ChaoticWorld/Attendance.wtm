using em_wtm.Model._Business.Attendance;
using System.Collections.Generic;
using System.Linq;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2DayTypeVMs
{
    public partial class Attendance2DayTypeListVM : BasePagedListVM<Attendance2DayType_View, Attendance2DayTypeSearcher>
    {

        protected override IEnumerable<IGridColumn<Attendance2DayType_View>> InitGridHeader()
        {
            return new List<GridColumn<Attendance2DayType_View>>{
                this.MakeGridHeader(x => x.DayTypeName),
                this.MakeGridHeader(x => x.DayTypeCaption),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Attendance2DayType_View> GetSearchQuery()
        {
            var query = DC.Set<Attendance2DayType>()
                .Select(x => new Attendance2DayType_View
                {
                    ID = x.ID,
                    DayTypeName = x.DayTypeName,
                    DayTypeCaption = x.DayTypeCaption,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Attendance2DayType_View : Attendance2DayType
    {

    }
}
