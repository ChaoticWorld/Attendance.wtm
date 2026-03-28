using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace em_wtm.Model._Business.Attendance
{
    /// <summary>
    /// 假日调休
    /// </summary>
    [Table("Attendance2_Holiday")]
    [Display(Name = "假日调休")]
    public partial class Attendance2Holiday : TopBasePoco
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
        /// 年份
        /// </summary>
        [Display(Name = "年份")]
        [Required]
        public int IYear { get; set; }

        /// <summary>
        /// 日期字符串yyyy-MM-dd
        /// </summary>
        [Display(Name = "日期")]
        [Required]
        //[RegularExpression("([0-9]{3}[1-9]|[0-9]{2}[1-9][0-9]{1}|[0-9]{1}[1-9][0-9]{2}|[1-9][0-9]{3})-(((0[13578]|1[02])-(0[1-9]|[12][0-9]|3[01]))|((0[469]|11)-(0[1-9]|[12][0-9]|30))|(02-(0[1-9]|[1][0-9]|2[0-8])))", ErrorMessage = "Validate.{0}formaterror")]
        //[RegularExpression("^(?:(?!0000)[0-9]{4}([-/.]?)(?:(?:0?[1-9]|1[0-2])\\1(?:0?[1-9]|1[0-9]|2[0-8])|(?:0?[13-9]|1[0-2])\\1(?:29|30)|(?:0?[13578]|1[02])\\1(?:31))|(?:[0-9]{2}(?:0[48]|[2468][048]|[13579][26])|(?:0[48]|[2468][048]|[13579][26])00)([-/.]?)0?2\\2(?:29))$", ErrorMessage = "Validate.{0}formaterror")]
        public DateTime? SDate { get; set; }

        /// <summary>
        /// 节假日名称
        /// </summary>
        [Display(Name = "节假日名称")]
        public string SName { get; set; }

        /// <summary>
        /// 上班时间字符串-HH:mm:ss.nnn
        /// </summary>
        [Display(Name = "上班时间")]
        [RegularExpression("([01][0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]", ErrorMessage = "Validate.{0}formaterror")]
        public TimeSpan? BTime { get; set; }

        /// <summary>
        /// 下班时间字符串-HH:mm:ss.nnn
        /// </summary>
        [Display(Name = "下班时间")]
        [RegularExpression("([01][0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]", ErrorMessage = "Validate.{0}formaterror")]
        public TimeSpan? ETime { get; set; }

        /// <summary>
        /// 节假日描述
        /// </summary>
        [Display(Name = "节假日描述")]
        public string SDescription { get; set; }
    }
}