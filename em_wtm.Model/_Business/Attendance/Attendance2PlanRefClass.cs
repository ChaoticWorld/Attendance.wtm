using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Attributes;

namespace em_wtm.Model._Business.Attendance
{
    /// <summary>
    /// 排班标准时间与班次关联表
    /// </summary>
    [MiddleTable]
    [Table("Attendance2_PlanRefClass")]
    [Display(Name = "排班标准时间与班次关联表")]
    public partial class Attendance2PlanRefClass : TopBasePoco
    {
        [Display(Name = "序号")]
        [Key]
        [Column("AutoId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public new int ID { get; set; }

        /// <summary>
        /// 班次ID
        /// </summary>
        [Display(Name = "班次")]
        [Column("ClassId")]
        public int? ClassId { get; set; }
        public Attendance2SchemeClass Class { get; set; }

        /// <summary>
        /// 计划ID
        /// </summary>
        [Display(Name = "排班计划")]
        [Column("PlanId")]
        public int PlanId { get; set; }
        public Attendance2PlanTime Plan { get; set; }

        /// <summary>
        /// 周期序号
        /// </summary>
        [Display(Name = "周期序号")]
        public int? PeriodNo { get; set; }
    }
}