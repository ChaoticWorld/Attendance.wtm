using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace em_wtm.Model._Business.Report {
    [Table("Report_Layout ")]
    [Display(Name = "报表布局")]
    public partial class ReportLayout : TopBasePoco {
        [Key]
        [Display(Name = "布局ID")]
        [Column("LayoutId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public new int ID { get; set; }

        [Display(Name = "报表ID")]
        [Column("reportId")]
        public new int ReportID { get; set; }
        public ReportMain Report { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [Display(Name = "标题")]
        public string Title { get; set; }

        /// <summary>
        /// 组件尺寸_宽
        /// </summary>
        [Display(Name = "宽")]
        public int? Width { get; set; }
        /// <summary>
        /// 组件尺寸_高
        /// </summary>
        [Display(Name = "高")]
        public int? Hight { get; set; }
        /// <summary>
        /// 组件尺寸_锁定
        /// </summary>
        [Display(Name = "锁")]
        public bool isLock { get; set; }


        /// <summary>
        /// 数据链接名
        /// </summary>
        [Display(Name = "数据链接名")]
        public string DBConnection { get; set; }
        [NotMapped]
        [Display(Name = "报表类型")]//明细表-table,看板-board
        public string Style { get; set; }
        [NotMapped]
        public List<ReportScript> reportScripts { get; set; }
    }
}