using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using em_wtm.Model._Business.Report;


namespace em_wtm.ViewModel.Report.ReportMainVMs
{
    public partial class ReportMainBatchVM : BaseBatchVM<ReportMain, ReportMain_BatchEdit>
    {
        public ReportMainBatchVM()
        {
            ListVM = new ReportMainListVM();
            LinkedVM = new ReportMain_BatchEdit();
        }

    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class ReportMain_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
