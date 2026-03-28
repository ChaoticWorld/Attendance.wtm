using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.VAttendanceReportVMs
{
    public partial class VAttendanceReportSearcher : BaseSearcher
    {
        [Display(Name = "员工姓名")]
        public int? EmployeeId { get; set; }
        [Display(Name = "日期")]
        public DateRange SDate { get; set; }

        protected override void InitVM()
        {
        }

    }
}
