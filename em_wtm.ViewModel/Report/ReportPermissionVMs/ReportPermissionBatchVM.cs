using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using em_wtm.Model._Business.Report;


namespace em_wtm.ViewModel.Report.ReportPermissionVMs
{
    public partial class ReportPermissionBatchVM : BaseBatchVM<ReportPermission, ReportPermission_BatchEdit>
    {
        public ReportPermissionBatchVM()
        {
            ListVM = new ReportPermissionListVM();
            LinkedVM = new ReportPermission_BatchEdit();
        }

    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class ReportPermission_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
