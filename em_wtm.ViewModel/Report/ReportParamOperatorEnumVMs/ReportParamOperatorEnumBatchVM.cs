using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using em_wtm.Model._Business.Report;


namespace em_wtm.ViewModel.Report.ReportParamOperatorEnumVMs
{
    public partial class ReportParamOperatorEnumBatchVM : BaseBatchVM<ReportParamOperatorEnum, ReportParamOperatorEnum_BatchEdit>
    {
        public ReportParamOperatorEnumBatchVM()
        {
            ListVM = new ReportParamOperatorEnumListVM();
            LinkedVM = new ReportParamOperatorEnum_BatchEdit();
        }

    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class ReportParamOperatorEnum_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
