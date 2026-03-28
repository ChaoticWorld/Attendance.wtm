using em_wtm.Model._Business.Attendance;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2DayTypeVMs
{
    public partial class Attendance2DayTypeTemplateVM : BaseTemplateVM
    {
        [Display(Name = "日期类型名称")]
        public ExcelPropety DayTypeName_Excel = ExcelPropety.CreateProperty<Attendance2DayType>(x => x.DayTypeName);
        [Display(Name = "日期类型标题")]
        public ExcelPropety DayTypeCaption_Excel = ExcelPropety.CreateProperty<Attendance2DayType>(x => x.DayTypeCaption);

        protected override void InitVM()
        {
        }

    }

    public class Attendance2DayTypeImportVM : BaseImportVM<Attendance2DayTypeTemplateVM, Attendance2DayType>
    {

    }

}
