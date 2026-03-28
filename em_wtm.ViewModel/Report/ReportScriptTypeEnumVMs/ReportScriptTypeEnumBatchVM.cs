using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using em_wtm.Model._Business.Report;


namespace em_wtm.ViewModel.Report.ReportScriptTypeEnumVMs
{
    public partial class ReportScriptTypeEnumBatchVM : BaseBatchVM<ReportScriptTypeEnum, ReportScriptTypeEnum_BatchEdit>
    {
        public ReportScriptTypeEnumBatchVM()
        {
            ListVM = new ReportScriptTypeEnumListVM();
            LinkedVM = new ReportScriptTypeEnum_BatchEdit();
        }

    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class ReportScriptTypeEnum_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
