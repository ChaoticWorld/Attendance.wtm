using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace em_wtm.Model._Business.Attendance
{
    /// <summary>
    /// 费用计算
    /// </summary>
    [Table("Attendance2_FeeCalculator")]
    [Display(Name = "费用计算")]
    public partial class Attendance2FeeCalculator : TopBasePoco
    {
        /// <summary>
        /// 序号
        /// </summary>
        [Display(Name = "序号")]
        [Key]
        [Column("FeeId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public new int ID { get; set; }

        /// <summary>
        /// 日期类型ID
        /// </summary>
        [Display(Name = "日期类型")]
        //[Column("DayTypeId")]
        public int DayTypeId { get; set; }
        public Attendance2DayType DayType { get; set; }

        /// <summary>
        /// 时长范围A,A &gt; x &gt;= B
        /// </summary>
        [Display(Name = "时长范围A")]
        public int? RangeA { get; set; }

        /// <summary>
        /// 时长范围B,A &gt; x &gt;= B
        /// </summary>
        [Display(Name = "时长范围B")]
        public int? RangeB { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [Display(Name = "金额")]
        public decimal? RangePrice { get; set; }
    }
}