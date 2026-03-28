using em_wtm.Model._Business.Attendance;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;


namespace em_wtm.ViewModel.Attendance.Attendance2PlanTimeVMs
{
    public partial class Attendance2PlanTimeTemplateVM : BaseTemplateVM
    {
        [Display(Name = "计划名")]
        public ExcelPropety PlanName_Excel = ExcelPropety.CreateProperty<Attendance2PlanTime>(x => x.PlanName);
        public ExcelPropety DayType_Excel = ExcelPropety.CreateProperty<Attendance2PlanTime>(x => x.DayTypeId);
        [Display(Name = "描述")]
        public ExcelPropety Description_Excel = ExcelPropety.CreateProperty<Attendance2PlanTime>(x => x.Description);

        protected override void InitVM()
        {
            DayType_Excel.DataType = ColumnDataType.ComboBox;
            DayType_Excel.ListItems = DC.Set<Attendance2DayType>().GetSelectListItems(Wtm, y => y.DayTypeName);
        }

    }

    public class Attendance2PlanTimeImportVM : BaseImportVM<Attendance2PlanTimeTemplateVM, Attendance2PlanTime>
    {

    }

}
