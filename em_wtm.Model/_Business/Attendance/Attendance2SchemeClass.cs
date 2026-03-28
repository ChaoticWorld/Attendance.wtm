using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace em_wtm.Model._Business.Attendance
{
    [Table("Attendance2_SchemeClass")]
    [Display(Name = "考勤班次")]
    /// <summary>
    /// 班次信息
    /// </summary>
    public class Attendance2SchemeClass : TopBasePoco
    {
        /// <summary>
        /// 班次id
        /// </summary>
        [Display(Name = "班次ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("ClassId")]
        public new int ID { get; set; }

        /// <summary>
        /// 班次名
        /// </summary>
        [Display(Name = "班次名")]
        public string ClassName { get; set; }


        /// <summary>
        /// 总排班数
        /// </summary>
        [Display(Name = "总排班数")]
        public int? Periods { get; set; }

        /// <summary>
        /// 班次描述
        /// </summary>
        [Display(Name = "班次描述")]
        public string ClassDescription { get; set; }

        /// <summary>
        /// 班次内周期
        /// </summary>
        [Display(Name = "班次内周期")]
        public int? ClassPeriods { get; set; }
    }
}