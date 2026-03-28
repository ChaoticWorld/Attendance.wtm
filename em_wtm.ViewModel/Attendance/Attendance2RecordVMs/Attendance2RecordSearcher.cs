using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2RecordVMs
{
    public partial class Attendance2RecordSearcher : BaseSearcher
    {
        public int? EmployeeId { get; set; }
        [Display(Name = "日期")]
        public DateRange SDate { get; set; }

        protected override void InitVM()
        {
        }

    }
}
