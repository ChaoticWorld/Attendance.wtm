using em_wtm.Model._Business.Attendance;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2HolidayVMs
{
    public partial class Attendance2HolidayTemplateVM : BaseTemplateVM
    {
        [Display(Name = "年份")]
        public ExcelPropety IYear_Excel = ExcelPropety.CreateProperty<Attendance2Holiday>(x => x.IYear);
        [Display(Name = "日期")]
        public ExcelPropety SDate_Excel = ExcelPropety.CreateProperty<Attendance2Holiday>(x => x.SDate);
        [Display(Name = "节假日名称")]
        public ExcelPropety SName_Excel = ExcelPropety.CreateProperty<Attendance2Holiday>(x => x.SName);
        [Display(Name = "节假日描述")]
        public ExcelPropety SDescription_Excel = ExcelPropety.CreateProperty<Attendance2Holiday>(x => x.SDescription);

        protected override void InitVM()
        {
        }

    }

    public class Attendance2HolidayImportVM : BaseImportVM<Attendance2HolidayTemplateVM, Attendance2Holiday>
    {

    }

}
