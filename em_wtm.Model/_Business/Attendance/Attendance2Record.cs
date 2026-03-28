using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace em_wtm.Model._Business.Attendance
{
    [Table("Attendance2_Records")]
    [Display(Name = "考勤记录")]
    public partial class Attendance2Record : TopBasePoco
    {
        /// <summary>
        /// 序号
        /// </summary>
        [Display(Name = "序号")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("RecordId")]
        public new int ID { get; set; }

        /// <summary>
        /// 考勤机员工ID
        /// </summary>
        [Display(Name = "考勤员工")]
        public int EmployeeId { get; set; }
        public VAttendanceEmployee Employee { get; set; }

        /// <summary>
        /// 周期内次序号
        /// </summary>
        [Display(Name = "周期内次序号")]
        public int PeriodNo { get; set; }

        /// <summary>
        /// 日期字符串:yyyy-MM-dd
        /// </summary>
        [Display(Name = "日期")]
        //[RegularExpression("^(?:(?!0000)[0-9]{4}([-/.]?)(?:(?:0?[1-9]|1[0-2])\\1(?:0?[1-9]|1[0-9]|2[0-8])|(?:0?[13-9]|1[0-2])\\1(?:29|30)|(?:0?[13578]|1[02])\\1(?:31))|(?:[0-9]{2}(?:0[48]|[2468][048]|[13579][26])|(?:0[48]|[2468][048]|[13579][26])00)([-/.]?)0?2\\2(?:29))$", ErrorMessage = "Validate.{0}formaterror")]
        public DateTime SDate { get; set; }
        //[Display(Name = "s日期")]
        //[NotMapped]
        //public string SDateString { get { return SDate.ToString("yyyy-MM-dd"); } }

        /// <summary>
        /// b上班考勤时间字符串-HH:mm:ss.000
        /// </summary>
        [Display(Name = "上班考勤时间")]
        public TimeSpan? BAttTime { get; set; }

        /// <summary>
        /// e下班考勤时间字符串-HH:mm:ss.000
        /// </summary>
        [Display(Name = "下班考勤时间")]
        public TimeSpan? EAttTime { get; set; }

        /// <summary>
        /// b上班考勤偏移量（单位分钟：正为加班，负为早退）
        /// </summary>
        [Display(Name = "上班考勤时长")]
        public int? BOffset { get; set; }

        /// <summary>
        /// e下班考勤偏移量（单位分钟：正为加班，负为早退）
        /// </summary>
        [Display(Name = "下班考勤时长")]
        public int? EOffset { get; set; }

        [Display(Name = "上班考勤费")]
        public decimal? BOffsetFee { get; set; }

        [Display(Name = "下班考勤费")]
        public decimal? EOffsetFee { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [Display(Name = "上班标准时间")]
        public TimeSpan? BTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [Display(Name = "下班标准时间")]
        public TimeSpan? ETime { get; set; }

        /// <summary>
        /// 日期类型ID
        /// </summary>
        [Display(Name = "日期类型")]
        [Column("DayTypeId")]
        public int? DayTypeId { get; set; }
        public Attendance2DayType DayType { get; set; }

        /// <summary>
        /// 计划ID
        /// </summary>
        [Display(Name = "排班计划")]
        [Column("PlanId")]
        public int? PlanId { get; set; }
        [Display(Name = "排班计划")]
        public Attendance2PlanTime Plan { get; set; }

        /// <summary>
        /// 方案班次
        /// </summary>
        [Display(Name = "方案班次")]
        [Column("ClassId")]
        public int? ClassId { get; set; }
        public Attendance2SchemeClass Class { get; set; }

        [Display(Name = "考勤事件")]
        public List<Attendance2EventDeclared> EventDeclareds { get; set; }
    }
}