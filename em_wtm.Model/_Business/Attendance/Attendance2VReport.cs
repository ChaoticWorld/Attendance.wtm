using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace em_wtm.Model._Business.Attendance
{
    [Table("V_AttendanceReport")]
    [Display(Name = "考勤报表")]

    public partial class VAttendanceReport : TopBasePoco
    {
        /// <summary>
        /// 考勤记录序号
        /// </summary>
        [Display(Name = "考勤记录序号")]
        [Key]
        [Column("RecordID")]
        public new int ID { get; set; }

        [Display(Name = "员工ID")]
        public int EmployeeId { get; set; }
        [Display(Name = "员工姓名")]
        public VAttendanceEmployee Employee { get; set; }
        [Display(Name = "日期")]
        public DateTime SDate { get; set; }
        [Display(Name = "周")]
        public string? Description { get; set; }
        [Display(Name = "上班时间")]
        public TimeSpan? BAttTime { get; set; }
        [Display(Name = "上班时长")]
        public int? BOffset { get; set; }
        [Display(Name = "下班时间")]
        public TimeSpan? EAttTime { get; set; }
        [Display(Name = "下班时长")]
        public int? EOffset { get; set; }
        [Display(Name = "事由")]
        public string? Event { get; set; }
        [Display(Name = "上班事件费用")]
        public decimal? bOffsetFee { get; set; }
        [Display(Name = "下班事件费用")]
        public decimal? eOffsetFee { get; set; }

        [Display(Name = "费用")]
        public decimal? Fee { get; set; }
        [NotMapped]
        public bool isBTimeClicked { get; set; }
    }
}
