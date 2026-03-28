using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using em_wtm.Model._Business.Report;


namespace em_wtm.ViewModel.Report.ReportPermissionVMs
{
    public partial class ReportPermissionTemplateVM : BaseTemplateVM
    {
        public ExcelPropety Report_Excel = ExcelPropety.CreateProperty<ReportPermission>(x => x.ReportId);
        public ExcelPropety User_Excel = ExcelPropety.CreateProperty<ReportPermission>(x => x.UserId);

	    protected override void InitVM()
        {
            Report_Excel.DataType = ColumnDataType.ComboBox;
            Report_Excel.ListItems = DC.Set<ReportMain>().GetSelectListItems(Wtm, y => y.Name);
            User_Excel.DataType = ColumnDataType.ComboBox;
            User_Excel.ListItems = DC.Set<FrameworkUser>().GetSelectListItems(Wtm, y => y.Name);
        }

    }

    public class ReportPermissionImportVM : BaseImportVM<ReportPermissionTemplateVM, ReportPermission>
    {

    }

}
