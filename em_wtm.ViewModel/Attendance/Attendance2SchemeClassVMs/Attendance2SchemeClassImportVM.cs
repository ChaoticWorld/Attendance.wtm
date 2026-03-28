using em_wtm.Model._Business.Attendance;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2SchemeClassVMs
{
    public partial class Attendance2SchemeClassTemplateVM : BaseTemplateVM
    {
        [Display(Name = "班次名")]
        public ExcelPropety ClassName_Excel = ExcelPropety.CreateProperty<Attendance2SchemeClass>(x => x.ClassName);
        [Display(Name = "总排班数")]
        public ExcelPropety Periods_Excel = ExcelPropety.CreateProperty<Attendance2SchemeClass>(x => x.Periods);
        [Display(Name = "班次描述")]
        public ExcelPropety ClassDescription_Excel = ExcelPropety.CreateProperty<Attendance2SchemeClass>(x => x.ClassDescription);
        [Display(Name = "班次内周期")]
        public ExcelPropety ClassPeriods_Excel = ExcelPropety.CreateProperty<Attendance2SchemeClass>(x => x.ClassPeriods);

        protected override void InitVM()
        {
        }

    }

    public class Attendance2SchemeClassImportVM : BaseImportVM<Attendance2SchemeClassTemplateVM, Attendance2SchemeClass>
    {

    }

}
