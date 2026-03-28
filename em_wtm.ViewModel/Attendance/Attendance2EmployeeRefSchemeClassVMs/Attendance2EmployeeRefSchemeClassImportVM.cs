using em_wtm.Model._Business.Attendance;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;


namespace em_wtm.ViewModel.Attendance.Attendance2EmployeeRefSchemeClassVMs
{
    public partial class Attendance2EmployeeRefSchemeClassTemplateVM : BaseTemplateVM
    {
        [Display(Name = "序号")]
        public ExcelPropety ID_Excel = ExcelPropety.CreateProperty<Attendance2EmployeeRefSchemeClass>(x => x.ID);
        public ExcelPropety User_Excel = ExcelPropety.CreateProperty<Attendance2EmployeeRefSchemeClass>(x => x.UserId);
        [Display(Name = "考勤机员工ID")]
        public ExcelPropety EmployeeId_Excel = ExcelPropety.CreateProperty<Attendance2EmployeeRefSchemeClass>(x => x.EmployeeId);
        public ExcelPropety Class_Excel = ExcelPropety.CreateProperty<Attendance2EmployeeRefSchemeClass>(x => x.ClassId);
        [Display(Name = "生效日期")]
        public ExcelPropety EffDate_Excel = ExcelPropety.CreateProperty<Attendance2EmployeeRefSchemeClass>(x => x.EffDate);
        [Display(Name = "生效周期序号")]
        public ExcelPropety PeriodNo_Excel = ExcelPropety.CreateProperty<Attendance2EmployeeRefSchemeClass>(x => x.PeriodNo);
        [Display(Name = "失效日期")]
        public ExcelPropety ExpDate_Excel = ExcelPropety.CreateProperty<Attendance2EmployeeRefSchemeClass>(x => x.ExpDate);
        [Display(Name = "考勤机员工名")]
        public ExcelPropety EmployeeName_Excel = ExcelPropety.CreateProperty<Attendance2EmployeeRefSchemeClass>(x => x.EmployeeName);

        protected override void InitVM()
        {
            User_Excel.DataType = ColumnDataType.ComboBox;
            User_Excel.ListItems = DC.Set<FrameworkUser>().GetSelectListItems(Wtm, y => y.Name);
            Class_Excel.DataType = ColumnDataType.ComboBox;
            Class_Excel.ListItems = DC.Set<Attendance2SchemeClass>().GetSelectListItems(Wtm, y => y.ClassName);
        }

    }

    public class Attendance2EmployeeRefSchemeClassImportVM : BaseImportVM<Attendance2EmployeeRefSchemeClassTemplateVM, Attendance2EmployeeRefSchemeClass>
    {

    }

}
