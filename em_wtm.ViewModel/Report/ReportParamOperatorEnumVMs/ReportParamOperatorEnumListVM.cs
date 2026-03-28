using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using em_wtm.Model._Business.Report;


namespace em_wtm.ViewModel.Report.ReportParamOperatorEnumVMs
{
    public partial class ReportParamOperatorEnumListVM : BasePagedListVM<ReportParamOperatorEnum_View, ReportParamOperatorEnumSearcher>
    {

        protected override IEnumerable<IGridColumn<ReportParamOperatorEnum_View>> InitGridHeader()
        {
            return new List<GridColumn<ReportParamOperatorEnum_View>>{
                this.MakeGridHeader(x => x.Operator),
                this.MakeGridHeader(x => x.OperatorTips),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<ReportParamOperatorEnum_View> GetSearchQuery()
        {
            var query = DC.Set<ReportParamOperatorEnum>()
                .Select(x => new ReportParamOperatorEnum_View
                {
                    ID = x.ID,
                    Operator = x.Operator,
                    OperatorTips = x.OperatorTips,
                }) 
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class ReportParamOperatorEnum_View : ReportParamOperatorEnum {
    }
}
