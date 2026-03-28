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
    public partial class ReportScriptTypeEnumTemplateVM : BaseTemplateVM
    {
        [Display(Name = "脚本类型")]
        public ExcelPropety Name_Excel = ExcelPropety.CreateProperty<ReportScriptTypeEnum>(x => x.Name);
        [Display(Name = "拼接参数的方法名")]
        public ExcelPropety Module_Excel = ExcelPropety.CreateProperty<ReportScriptTypeEnum>(x => x.Module);

	    protected override void InitVM()
        {
        }

    }

    public class ReportScriptTypeEnumImportVM : BaseImportVM<ReportScriptTypeEnumTemplateVM, ReportScriptTypeEnum>
    {

    }

}
