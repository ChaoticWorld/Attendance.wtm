using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using em_wtm.Model._Business.Report;


namespace em_wtm.ViewModel.Report.ReportScriptTypeEnumVMs
{
    public partial class ReportScriptTypeEnumListVM : BasePagedListVM<ReportScriptTypeEnum_View, ReportScriptTypeEnumSearcher>
    {

        protected override IEnumerable<IGridColumn<ReportScriptTypeEnum_View>> InitGridHeader()
        {
            return new List<GridColumn<ReportScriptTypeEnum_View>>{
                this.MakeGridHeader(x => x.Name),
                this.MakeGridHeader(x => x.Module),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<ReportScriptTypeEnum_View> GetSearchQuery()
        {
            var query = DC.Set<ReportScriptTypeEnum>()
                .Select(x => new ReportScriptTypeEnum_View
                {
				    ID = x.ID,
                    Name = x.Name,
                    Module = x.Module,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class ReportScriptTypeEnum_View : ReportScriptTypeEnum{

    }
}
