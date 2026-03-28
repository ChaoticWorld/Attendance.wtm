using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using em_wtm.Model._Business.Report;


namespace em_wtm.ViewModel.Report.ReportScriptVMs
{
    public partial class ReportScriptListVM : BasePagedListVM<ReportScript_View, ReportScriptSearcher>
    {

        protected override IEnumerable<IGridColumn<ReportScript_View>> InitGridHeader()
        {
            return new List<GridColumn<ReportScript_View>>{
                this.MakeGridHeader(x => x.Name_view),
                this.MakeGridHeader(x => x.Script),
                this.MakeGridHeader(x => x.Name_view2),
                this.MakeGridHeader(x => x.ScriptOrder),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<ReportScript_View> GetSearchQuery()
        {
            var query = DC.Set<ReportScript>()
                .CheckEqual(Searcher.ReportId, x=>x.ReportID)
                .Select(x => new ReportScript_View
                {
				    ID = x.ID,
                    Name_view = x.Report.Name,
                    Script = x.Script,
                    Name_view2 = x.ScriptType.Name,
                    ScriptOrder = x.ScriptOrder,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class ReportScript_View : ReportScript{
        [Display(Name = "名称")]
        public String Name_view { get; set; }
        [Display(Name = "脚本类型")]
        public String Name_view2 { get; set; }

    }
}
