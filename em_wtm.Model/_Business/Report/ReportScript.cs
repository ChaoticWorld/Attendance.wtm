using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace em_wtm.Model._Business.Report
{
    [Table("Report_Script")]
    [Display(Name = "报表脚本")]
    public partial class ReportScript : TopBasePoco
    {
        [Key]
        [Display(Name = "脚本ID")]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public new int ID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Display(Name = "报表ID")]
        public int? ReportID { get; set; }
        public ReportMain Report { get; set; }
        /// <summary>
        /// 脚本
        /// </summary>
        [Display(Name = "脚本内容")]
        public string Script { get; set; }
        /// <summary>
        /// 脚本类型ID
        /// </summary>
        [Display(Name = "脚本类型ID")]
        public int? ScriptTypeId { get; set; }
        public ReportScriptTypeEnum ScriptType { get; set; }
        
        /// <summary>
        /// 脚本执行顺序
        /// </summary>
        /// 
        [Display(Name = "脚本顺序")]
        public int? ScriptOrder { get; set; }

        [NotMapped]
        public List<ReportScriptParam> Parameters { get; set; }
    }
}
