using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace em_wtm.Model._Business.Attendance
{
    /// <summary>
    /// 日期类型
    /// </summary>
    [Table("Attendance2_DayType")]
    [Display(Name = "日期类型")]
    public partial class Attendance2DayType : TopBasePoco
    {
        /// <summary>
        /// ID -DayTypeId
        /// </summary>
        [Key]
        [Display(Name = "日期类型ID")]
        [Column("DayTypeId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public new int ID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Display(Name = "日期类型名称")]
        public string DayTypeName { get; set; }

        /// <summary>
        /// 显示
        /// </summary>
        [Display(Name = "日期类型标题")]
        public string DayTypeCaption { get; set; }
    }
}
