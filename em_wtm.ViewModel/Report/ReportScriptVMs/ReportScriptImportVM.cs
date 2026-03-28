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
    public partial class ReportScriptTemplateVM : BaseTemplateVM
    {
        public ExcelPropety Report_Excel = ExcelPropety.CreateProperty<ReportScript>(x => x.ReportID);
        [Display(Name = "脚本内容")]
        public ExcelPropety Script_Excel = ExcelPropety.CreateProperty<ReportScript>(x => x.Script);
        public ExcelPropety ScriptType_Excel = ExcelPropety.CreateProperty<ReportScript>(x => x.ScriptTypeId);
        [Display(Name = "脚本顺序")]
        public ExcelPropety ScriptOrder_Excel = ExcelPropety.CreateProperty<ReportScript>(x => x.ScriptOrder);

	    protected override void InitVM()
        {
            Report_Excel.DataType = ColumnDataType.ComboBox;
            Report_Excel.ListItems = DC.Set<ReportMain>().GetSelectListItems(Wtm, y => y.Name);
            ScriptType_Excel.DataType = ColumnDataType.ComboBox;
            ScriptType_Excel.ListItems = DC.Set<ReportScriptTypeEnum>().GetSelectListItems(Wtm, y => y.Name);
        }

    }

    public class ReportScriptImportVM : BaseImportVM<ReportScriptTemplateVM, ReportScript>
    {

    }

}
