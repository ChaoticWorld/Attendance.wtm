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
    public partial class ReportParamOperatorEnumTemplateVM : BaseTemplateVM
    {
        [Display(Name = "比较符")]
        public ExcelPropety Operator_Excel = ExcelPropety.CreateProperty<ReportParamOperatorEnum>(x => x.Operator);
        [Display(Name = "提示")]
        public ExcelPropety OperatorTips_Excel = ExcelPropety.CreateProperty<ReportParamOperatorEnum>(x => x.OperatorTips);

	    protected override void InitVM()
        {
        }

    }

    public class ReportParamOperatorEnumImportVM : BaseImportVM<ReportParamOperatorEnumTemplateVM, ReportParamOperatorEnum>
    {

    }

}
