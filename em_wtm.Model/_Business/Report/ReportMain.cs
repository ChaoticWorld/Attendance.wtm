using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace em_wtm.Model._Business.Report
{
    [Table("Report_Main ")]
    [Display(Name = "报表")]
    public partial class ReportMain : TopBasePoco
    {
        [Key]
        [Display(Name = "报表ID")]
        [Column("reportId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public new int ID { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [Display(Name = "描述")]
        public string Description { get; set; }
        [Display(Name = "名称")]
        public string Name { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [Display(Name = "标题")]
        public string Title { get; set; }
        /// <summary>
        /// 数据链接名
        /// </summary>
        [Display(Name = "数据链接名")]
        public string DBConnection { get; set; }

        [NotMapped]
        public List<ReportScript> reportScripts { get; set; }
    }
}
