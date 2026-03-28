using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using em_wtm.Model._Business.Report;


namespace em_wtm.ViewModel.Report.ReportScriptParamVMs
{
    public partial class ReportScriptParamListVM : BasePagedListVM<ReportScriptParam_View, ReportScriptParamSearcher>
    {

        protected override IEnumerable<IGridColumn<ReportScriptParam_View>> InitGridHeader()
        {
            return new List<GridColumn<ReportScriptParam_View>>{
                this.MakeGridHeader(x => x.Name_view),
                this.MakeGridHeader(x => x.Script_view),
                this.MakeGridHeader(x => x.Name),
                this.MakeGridHeader(x => x.Field),
                this.MakeGridHeader(x => x.Description),
                this.MakeGridHeader(x => x.Operator_view),
                this.MakeGridHeader(x => x.DefaultValue),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<ReportScriptParam_View> GetSearchQuery()
        {
            var query = DC.Set<ReportScriptParam>()
                .CheckEqual(Searcher.ReportID, x=>x.ReportID)
                .CheckEqual(Searcher.ScriptID, x=>x.ScriptID)
                .Select(x => new ReportScriptParam_View
                {
				    ID = x.ID,
                    Name_view = x.Report.Name,
                    Script_view = x.Script.Script,
                    Name = x.Name,
                    Field = x.Field,
                    Description = x.Description,
                    Operator_view = x.ParamOperator.Operator,
                    DefaultValue = x.DefaultValue,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class ReportScriptParam_View : ReportScriptParam{
        [Display(Name = "名称")]
        public String Name_view { get; set; }
        [Display(Name = "脚本内容")]
        public String Script_view { get; set; }
        [Display(Name = "比较符")]
        public String Operator_view { get; set; }

    }
}
