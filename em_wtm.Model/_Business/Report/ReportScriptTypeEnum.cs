using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace em_wtm.Model._Business.Report
{
    [Table("Report_ScriptTypeEnum ")]
    [Display(Name = "脚本类型")]
    public partial class ReportScriptTypeEnum : TopBasePoco
    {
        [Key]
        [Display(Name = "脚本类型ID")]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public new int ID { get; set; }
        [Display(Name = "脚本类型")]
        public string Name { get; set; }
        /// <summary>
        /// 拼接参数的方法名
        /// </summary>
        [Display(Name = "拼接参数的方法名")]
        public string Module { get; set; }
    }
}
