using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using em_wtm.Model._Business.Report;


namespace em_wtm.ViewModel.Report.ReportPermissionVMs
{
    public partial class ReportPermissionListVM : BasePagedListVM<ReportPermission_View, ReportPermissionSearcher>
    {

        protected override IEnumerable<IGridColumn<ReportPermission_View>> InitGridHeader()
        {
            return new List<GridColumn<ReportPermission_View>>{
                this.MakeGridHeader(x => x.Name_view),
                this.MakeGridHeader(x => x.Name_view2),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<ReportPermission_View> GetSearchQuery()
        {
            var query = DC.Set<ReportPermission>()
                .Select(x => new ReportPermission_View
                {
				    ID = x.ID,
                    Name_view = x.Report.Name,
                    Name_view2 = x.User.Name,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class ReportPermission_View : ReportPermission{
        [Display(Name = "名称")]
        public String Name_view { get; set; }
        [Display(Name = "_Admin.Name")]
        public String Name_view2 { get; set; }

    }
}
