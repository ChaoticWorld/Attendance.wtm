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
    public partial class ReportMainTemplateVM : BaseTemplateVM
    {
        [Display(Name = "描述")]
        public ExcelPropety Description_Excel = ExcelPropety.CreateProperty<ReportMain>(x => x.Description);
        [Display(Name = "名称")]
        public ExcelPropety Name_Excel = ExcelPropety.CreateProperty<ReportMain>(x => x.Name);
        [Display(Name = "标题")]
        public ExcelPropety Title_Excel = ExcelPropety.CreateProperty<ReportMain>(x => x.Title);
        [Display(Name = "数据链接名")]
        public ExcelPropety DBConnection_Excel = ExcelPropety.CreateProperty<ReportMain>(x => x.DBConnection);

	    protected override void InitVM()
        {
        }

    }

    public class ReportMainImportVM : BaseImportVM<ReportMainTemplateVM, ReportMain>
    {

    }

}
