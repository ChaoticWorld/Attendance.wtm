using em_wtm.Model._Business.Attendance;
using System.Collections.Generic;
using System.Linq;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;


namespace em_wtm.ViewModel.Attendance.Attendance2SchemeClassVMs
{
    public partial class Attendance2SchemeClassListVM : BasePagedListVM<Attendance2SchemeClass_View, Attendance2SchemeClassSearcher>
    {

        protected override IEnumerable<IGridColumn<Attendance2SchemeClass_View>> InitGridHeader()
        {
            return new List<GridColumn<Attendance2SchemeClass_View>>{
                this.MakeGridHeader(x => x.ClassName),
                this.MakeGridHeader(x => x.Periods),
                this.MakeGridHeader(x => x.ClassDescription),
                this.MakeGridHeader(x => x.ClassPeriods),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Attendance2SchemeClass_View> GetSearchQuery()
        {
            var query = DC.Set<Attendance2SchemeClass>()
                .CheckContain(Searcher.ClassName, x => x.ClassName)
                .CheckContain(Searcher.ClassDescription, x => x.ClassDescription)
                .Select(x => new Attendance2SchemeClass_View
                {
                    ID = x.ID,
                    ClassName = x.ClassName,
                    Periods = x.Periods,
                    ClassDescription = x.ClassDescription,
                    ClassPeriods = x.ClassPeriods,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Attendance2SchemeClass_View : Attendance2SchemeClass
    {

    }
}
