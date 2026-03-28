using em_wtm.Model._Business.Attendance;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;


namespace em_wtm.ViewModel.Attendance.Attendance2RecordVMs
{
    public partial class Attendance2RecordTemplateVM : BaseTemplateVM
    {
        public ExcelPropety Employee_Excel = ExcelPropety.CreateProperty<Attendance2Record>(x => x.EmployeeId);
        [Display(Name = "周期内次序号")]
        public ExcelPropety PeriodNo_Excel = ExcelPropety.CreateProperty<Attendance2Record>(x => x.PeriodNo);
        [Display(Name = "日期")]
        public ExcelPropety SDate_Excel = ExcelPropety.CreateProperty<Attendance2Record>(x => x.SDate);
        [Display(Name = "上班考勤时间")]
        public ExcelPropety BAttTime_Excel = ExcelPropety.CreateProperty<Attendance2Record>(x => x.BAttTime);
        [Display(Name = "下班考勤时间")]
        public ExcelPropety EAttTime_Excel = ExcelPropety.CreateProperty<Attendance2Record>(x => x.EAttTime);
        [Display(Name = "上班考勤时长")]
        public ExcelPropety BOffset_Excel = ExcelPropety.CreateProperty<Attendance2Record>(x => x.BOffset);
        [Display(Name = "下班考勤时长")]
        public ExcelPropety EOffset_Excel = ExcelPropety.CreateProperty<Attendance2Record>(x => x.EOffset);
        [Display(Name = "上班考勤费")]
        public ExcelPropety BOffsetFee_Excel = ExcelPropety.CreateProperty<Attendance2Record>(x => x.BOffsetFee);
        [Display(Name = "下班考勤费")]
        public ExcelPropety EOffsetFee_Excel = ExcelPropety.CreateProperty<Attendance2Record>(x => x.EOffsetFee);
        public ExcelPropety DayType_Excel = ExcelPropety.CreateProperty<Attendance2Record>(x => x.DayTypeId);
        [Display(Name = "排班计划")]
        public ExcelPropety Plan_Excel = ExcelPropety.CreateProperty<Attendance2Record>(x => x.PlanId);
        public ExcelPropety Class_Excel = ExcelPropety.CreateProperty<Attendance2Record>(x => x.ClassId);

        protected override void InitVM()
        {
            Employee_Excel.DataType = ColumnDataType.ComboBox;
            Employee_Excel.ListItems = DC.Set<VAttendanceEmployee>().GetSelectListItems(Wtm, y => y.EmployeeName);
            DayType_Excel.DataType = ColumnDataType.ComboBox;
            DayType_Excel.ListItems = DC.Set<Attendance2DayType>().GetSelectListItems(Wtm, y => y.DayTypeName);
            Plan_Excel.DataType = ColumnDataType.ComboBox;
            Plan_Excel.ListItems = DC.Set<Attendance2PlanTime>().GetSelectListItems(Wtm, y => y.PlanName);
            Class_Excel.DataType = ColumnDataType.ComboBox;
            Class_Excel.ListItems = DC.Set<Attendance2SchemeClass>().GetSelectListItems(Wtm, y => y.ClassName);
        }

    }

    public class Attendance2RecordImportVM : BaseImportVM<Attendance2RecordTemplateVM, Attendance2Record>
    {

    }

}
