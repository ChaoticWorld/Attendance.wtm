using em_wtm.Model._Business.Attendance;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;


namespace em_wtm.ViewModel.Attendance.Attendance2EventDeclaredVMs
{
    public partial class Attendance2EventDeclaredListVM : BasePagedListVM<Attendance2EventDeclared_View, Attendance2EventDeclaredSearcher>
    {

        protected override IEnumerable<IGridColumn<Attendance2EventDeclared_View>> InitGridHeader()
        {
            return new List<GridColumn<Attendance2EventDeclared_View>>{
                this.MakeGridHeader(x => x.EventDescription),
                this.MakeGridHeader(x => x.Fee),
                this.MakeGridHeader(x => x.Memo),
                this.MakeGridHeader(x => x.CheckMan),
                this.MakeGridHeader(x => x.Manager),
                this.MakeGridHeader(x => x.SDate),
                this.MakeGridHeader(x => x.IsBeginTime),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Attendance2EventDeclared_View> GetSearchQuery()
        {
            var query = DC.Set<Attendance2EventDeclared>()
                .CheckEqual(Searcher.RecordId, x => x.RecordId)
                .Select(x => new Attendance2EventDeclared_View
                {
                    ID = x.ID,
                    EventDescription = x.EventDescription,
                    Fee = x.Fee,
                    Memo = x.Memo,
                    CheckMan = x.CheckMan,
                    Manager = x.Manager,
                    SDate = x.Record.SDate.ToString("yyyy-MM-dd"),
                    IsBeginTime = x.IsBeginTime,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Attendance2EventDeclared_View : Attendance2EventDeclared
    {
        [Display(Name = "s日期")]
        public string SDate { get; set; }

    }
}
