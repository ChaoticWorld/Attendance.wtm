using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using em_wtm.Model._Business.Report;


namespace em_wtm.ViewModel.Report.ReportScriptVMs
{
    public partial class ReportScriptBatchVM : BaseBatchVM<ReportScript, ReportScript_BatchEdit>
    {
        public ReportScriptBatchVM()
        {
            ListVM = new ReportScriptListVM();
            LinkedVM = new ReportScript_BatchEdit();
        }

    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class ReportScript_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
