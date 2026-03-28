using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2SchemeClassVMs
{
    public partial class Attendance2SchemeClassSearcher : BaseSearcher
    {
        [Display(Name = "班次名")]
        public String ClassName { get; set; }
        [Display(Name = "班次描述")]
        public String ClassDescription { get; set; }

        protected override void InitVM()
        {
        }

    }
}
