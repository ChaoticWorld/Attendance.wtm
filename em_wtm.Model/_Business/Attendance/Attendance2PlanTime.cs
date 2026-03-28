using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using WalkingTec.Mvvm.Core;

namespace em_wtm.Model._Business.Attendance
{
    /// <summary>
    /// 排班标准时间
    /// </summary>
    [Table("Attendance2_PlanTime")]
    [Display(Name = "排班计划")]
    public partial class Attendance2PlanTime : TopBasePoco
    {
        /// <summary>
        /// 计划id
        /// </summary>
        [Display(Name = "计划ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("PlanId")]
        public new int ID { get; set; }

        /// <summary>
        /// 计划名
        /// </summary>
        [Display(Name = "计划名")]
        public string PlanName { get; set; }

        /// <summary>
        /// 日期类型id
        /// </summary>
        [Display(Name = "日期类型")]
        [Column("DayTypeId")]
        public int DayTypeId { get; set; }
        public Attendance2DayType DayType { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [Display(Name = "描述")]
        public string Description { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [Display(Name = "开始时间")]
        [RegularExpression("([01][0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]", ErrorMessage = "Validate.{0}formaterror")]
        public TimeSpan BTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [Display(Name = "结束时间")]
        [RegularExpression("([01][0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]", ErrorMessage = "Validate.{0}formaterror")]
        public TimeSpan ETime { get; set; }
    }
}