using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace em_wtm.Model._Business.Attendance
{

    /// <summary>
    /// 员工班次
    /// </summary>
    [Table("Attendance2_EmployeeRefSchemeClass")]
    [Display(Name = "员工班次")]
    public partial class Attendance2EmployeeRefSchemeClass : TopBasePoco
    {
        /// <summary>
        /// 序号
        /// </summary>
        [Display(Name = "序号")]
        [Key]
        [Column("Autoid")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public new int ID { get; set; }

        /// <summary>
        /// 用户号
        /// </summary>
        [Display(Name = "用户")]
        public Guid UserId { get; set; }
        public FrameworkUser User { get; set; }

        /// <summary>
        /// 考勤机员工ID
        /// </summary>
        [Display(Name = "考勤机员工ID")]
        public int EmployeeId { get; set; }

        /// <summary>
        /// 方案班次ID
        /// </summary>
        [Display(Name = "方案班次")]
        [Column("ClassId")]
        public int ClassId { get; set; }
        public Attendance2SchemeClass Class { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        [Display(Name = "生效日期")]
        [Required]
        //[RegularExpression("^(?:(?!0000)[0-9]{4}([-/.]?)(?:(?:0?[1-9]|1[0-2])\\1(?:0?[1-9]|1[0-9]|2[0-8])|(?:0?[13-9]|1[0-2])\\1(?:29|30)|(?:0?[13578]|1[02])\\1(?:31))|(?:[0-9]{2}(?:0[48]|[2468][048]|[13579][26])|(?:0[48]|[2468][048]|[13579][26])00)([-/.]?)0?2\\2(?:29))$", ErrorMessage = "Validate.{0}formaterror")]
        //[RegularExpression("([0-9]{3}[1-9]|[0-9]{2}[1-9][0-9]{1}|[0-9]{1}[1-9][0-9]{2}|[1-9][0-9]{3})-(((0[13578]|1[02])-(0[1-9]|[12][0-9]|3[01]))|((0[469]|11)-(0[1-9]|[12][0-9]|30))|(02-(0[1-9]|[1][0-9]|2[0-8])))", ErrorMessage = "Validate.{0}formaterror")]
        public DateTime EffDate { get; set; }

        /// <summary>
        /// 最后设定日期对应的记录周期号
        /// </summary>
        [Display(Name = "生效周期序号")]
        [Required]
        public int PeriodNo { get; set; }

        /// <summary>
        /// 失效日期
        /// </summary>
        [Display(Name = "失效日期")]
        //[RegularExpression("^(?:(?!0000)[0-9]{4}([-/.]?)(?:(?:0?[1-9]|1[0-2])\\1(?:0?[1-9]|1[0-9]|2[0-8])|(?:0?[13-9]|1[0-2])\\1(?:29|30)|(?:0?[13578]|1[02])\\1(?:31))|(?:[0-9]{2}(?:0[48]|[2468][048]|[13579][26])|(?:0[48]|[2468][048]|[13579][26])00)([-/.]?)0?2\\2(?:29))$", ErrorMessage = "Validate.{0}formaterror")]
        //[RegularExpression("^([0-9]{3}[1-9]|[0-9]{2}[1-9][0-9]{1}|[0-9]{1}[1-9][0-9]{2}|[1-9][0-9]{3})-(((0[13578]|1[02])-(0[1-9]|[12][0-9]|3[01]))|((0[469]|11)-(0[1-9]|[12][0-9]|30))|(02-(0[1-9]|[1][0-9]|2[0-8])))$", ErrorMessage = "Validate.{0}formaterror")]
        //[RegularExpression("([0-9]{4})-([0-9]{1,2}-[0-3]*[0-9])", ErrorMessage = "Validate.{0}formaterror")]
        public DateTime? ExpDate { get; set; }

        [Display(Name = "考勤机员工名")]
        public string? EmployeeName { get; set; }

    }
}