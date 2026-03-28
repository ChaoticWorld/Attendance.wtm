using em_wtm.Model._Business.Attendance;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;


namespace em_wtm.ViewModel.Attendance.Attendance2FeeCalculatorVMs
{
    public partial class Attendance2FeeCalculatorTemplateVM : BaseTemplateVM
    {
        public ExcelPropety DayType_Excel = ExcelPropety.CreateProperty<Attendance2FeeCalculator>(x => x.DayTypeId);
        [Display(Name = "时长范围A")]
        public ExcelPropety RangeA_Excel = ExcelPropety.CreateProperty<Attendance2FeeCalculator>(x => x.RangeA);
        [Display(Name = "时长范围B")]
        public ExcelPropety RangeB_Excel = ExcelPropety.CreateProperty<Attendance2FeeCalculator>(x => x.RangeB);
        [Display(Name = "金额")]
        public ExcelPropety RangePrice_Excel = ExcelPropety.CreateProperty<Attendance2FeeCalculator>(x => x.RangePrice);

        protected override void InitVM()
        {
            DayType_Excel.DataType = ColumnDataType.ComboBox;
            DayType_Excel.ListItems = DC.Set<Attendance2DayType>().GetSelectListItems(Wtm, y => y.DayTypeName);
        }

    }

    public class Attendance2FeeCalculatorImportVM : BaseImportVM<Attendance2FeeCalculatorTemplateVM, Attendance2FeeCalculator>
    {

    }

}
