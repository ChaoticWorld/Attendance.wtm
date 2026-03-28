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
    public partial class ReportScriptParamTemplateVM : BaseTemplateVM
    {
        public ExcelPropety Report_Excel = ExcelPropety.CreateProperty<ReportScriptParam>(x => x.ReportID);
        public ExcelPropety Script_Excel = ExcelPropety.CreateProperty<ReportScriptParam>(x => x.ScriptID);
        [Display(Name = "参数名")]
        public ExcelPropety Name_Excel = ExcelPropety.CreateProperty<ReportScriptParam>(x => x.Name);
        [Display(Name = "字段")]
        public ExcelPropety Field_Excel = ExcelPropety.CreateProperty<ReportScriptParam>(x => x.Field);
        [Display(Name = "描述")]
        public ExcelPropety Description_Excel = ExcelPropety.CreateProperty<ReportScriptParam>(x => x.Description);
        public ExcelPropety ParamOperator_Excel = ExcelPropety.CreateProperty<ReportScriptParam>(x => x.ParamOperatorID);
        [Display(Name = "缺省值")]
        public ExcelPropety DefaultValue_Excel = ExcelPropety.CreateProperty<ReportScriptParam>(x => x.DefaultValue);

	    protected override void InitVM()
        {
            Report_Excel.DataType = ColumnDataType.ComboBox;
            Report_Excel.ListItems = DC.Set<ReportMain>().GetSelectListItems(Wtm, y => y.Name);
            Script_Excel.DataType = ColumnDataType.ComboBox;
            Script_Excel.ListItems = DC.Set<ReportScript>().GetSelectListItems(Wtm, y => y.Script);
            ParamOperator_Excel.DataType = ColumnDataType.ComboBox;
            ParamOperator_Excel.ListItems = DC.Set<ReportParamOperatorEnum>().GetSelectListItems(Wtm, y => y.Operator);
        }

    }

    public class ReportScriptParamImportVM : BaseImportVM<ReportScriptParamTemplateVM, ReportScriptParam>
    {

    }

}
