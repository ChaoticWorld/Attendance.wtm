using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2EmployeeRefSchemeClassVMs
{
    public partial class Attendance2EmployeeRefSchemeClassSearcher : BaseSearcher
    {
        public int? ClassId { get; set; }
        [Display(Name = "考勤机员工名")]
        public String EmployeeName { get; set; }
        public Guid UserID { get; set; }

        protected override void InitVM()
        {
        }

    }
}
