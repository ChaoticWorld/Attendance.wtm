using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace em_wtm.Model._Business.Report
{
    [Table("Report_ScriptParams")]
    [Display(Name = "报表脚本参数")]
    public partial class ReportScriptParam : TopBasePoco
    {
        [Key]
        [Display(Name = "参数ID")]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public new int ID { get; set; }

        [Display(Name = "报表ID")]
        public int? ReportID { get; set; }
        public ReportMain Report { get; set; }

        [Display(Name = "脚本ID")]
        [Column("scriptID")]
        public int? ScriptID { get; set; }
        public ReportScript Script { get; set; }

        [Display(Name = "参数名")]
        public string Name { get; set; }
        /// <summary>
        /// 对应数据表字段
        /// </summary>
        [Display(Name = "字段")]
        public string Field { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [Display(Name = "描述")]
        public string Description { get; set; }
        /// <summary>
        /// 操作符
        /// </summary>
        [Display(Name = "比较符")]
        public int? ParamOperatorID { get; set; }
        public ReportParamOperatorEnum ParamOperator { get; set; }
        /// <summary>
        /// 缺省值
        /// </summary>
        [Display(Name = "缺省值")]
        public string DefaultValue { get; set; }
    }
}
