using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2PlanTimeVMs
{
    public partial class Attendance2PlanTimeSearcher : BaseSearcher
    {
        [Display(Name = "计划名")]
        public String PlanName { get; set; }
        [Display(Name = "描述")]
        public String Description { get; set; }

        protected override void InitVM()
        {
        }

    }
}
