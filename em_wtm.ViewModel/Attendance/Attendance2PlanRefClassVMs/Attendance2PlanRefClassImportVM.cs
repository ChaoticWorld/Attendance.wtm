using em_wtm.Model._Business.Attendance;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;


namespace em_wtm.ViewModel.Attendance.Attendance2PlanRefClassVMs
{
    public partial class Attendance2PlanRefClassTemplateVM : BaseTemplateVM
    {
        [Display(Name = "序号")]
        public ExcelPropety ID_Excel = ExcelPropety.CreateProperty<Attendance2PlanRefClass>(x => x.ID);
        public ExcelPropety Class_Excel = ExcelPropety.CreateProperty<Attendance2PlanRefClass>(x => x.ClassId);
        public ExcelPropety Plan_Excel = ExcelPropety.CreateProperty<Attendance2PlanRefClass>(x => x.PlanId);
        [Display(Name = "周期序号")]
        public ExcelPropety PeriodNo_Excel = ExcelPropety.CreateProperty<Attendance2PlanRefClass>(x => x.PeriodNo);

        protected override void InitVM()
        {
            Class_Excel.DataType = ColumnDataType.ComboBox;
            Class_Excel.ListItems = DC.Set<Attendance2SchemeClass>().GetSelectListItems(Wtm, y => y.ClassName);
            Plan_Excel.DataType = ColumnDataType.ComboBox;
            Plan_Excel.ListItems = DC.Set<Attendance2PlanTime>().GetSelectListItems(Wtm, y => y.PlanName);
        }

    }

    public class Attendance2PlanRefClassImportVM : BaseImportVM<Attendance2PlanRefClassTemplateVM, Attendance2PlanRefClass>
    {

    }

}
