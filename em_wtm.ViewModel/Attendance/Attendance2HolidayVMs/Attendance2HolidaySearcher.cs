using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2HolidayVMs
{
    public partial class Attendance2HolidaySearcher : BaseSearcher
    {
        [Display(Name = "年份")]
        public Int32? IYear { get; set; }
        [Display(Name = "节假日名称")]
        public String SName { get; set; }
        [Display(Name = "节假日描述")]
        public String SDescription { get; set; }

        protected override void InitVM()
        {
        }

    }
}
