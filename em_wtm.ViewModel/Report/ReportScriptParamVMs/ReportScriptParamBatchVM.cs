using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using em_wtm.Model._Business.Report;


namespace em_wtm.ViewModel.Report.ReportScriptParamVMs
{
    public partial class ReportScriptParamBatchVM : BaseBatchVM<ReportScriptParam, ReportScriptParam_BatchEdit>
    {
        public ReportScriptParamBatchVM()
        {
            ListVM = new ReportScriptParamListVM();
            LinkedVM = new ReportScriptParam_BatchEdit();
        }

    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class ReportScriptParam_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
