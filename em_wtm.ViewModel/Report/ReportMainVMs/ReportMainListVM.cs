using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using em_wtm.Model._Business.Report;


namespace em_wtm.ViewModel.Report.ReportMainVMs
{
    public partial class ReportMainListVM : BasePagedListVM<ReportMain_View, ReportMainSearcher>
    {

        protected override IEnumerable<IGridColumn<ReportMain_View>> InitGridHeader()
        {
            return new List<GridColumn<ReportMain_View>>{
                this.MakeGridHeader(x => x.Description),
                this.MakeGridHeader(x => x.Name),
                this.MakeGridHeader(x => x.Title),
                this.MakeGridHeader(x => x.DBConnection),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<ReportMain_View> GetSearchQuery()
        {
            var query = DC.Set<ReportMain>()
                .Select(x => new ReportMain_View
                {
				    ID = x.ID,
                    Description = x.Description,
                    Name = x.Name,
                    Title = x.Title,
                    DBConnection = x.DBConnection,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class ReportMain_View : ReportMain{

    }
}
