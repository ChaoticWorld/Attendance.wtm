using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;
using System.Text.Json.Serialization;

namespace em_wtm.Model._Business.Report {
    [Table("Report_ParamOperatorEnum ")]
    [Display(Name = "报表参数比较符")]
    public partial class ReportParamOperatorEnum : TopBasePoco {
        [Key]
        [Display(Name = "比较符枚举ID")]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public new int ID { get; set; }
        /// <summary>
        /// 操作符
        /// </summary>
        [Display(Name = "比较符")]
        [JsonConverter(typeof(JsonStringConverter))]
        public virtual string Operator { get; set; }
        /// <summary>
        /// 提示
        /// JsonConverter - 字符"<,>"不会被转码丢弃
        /// </summary>
        [Display(Name = "提示")]
        [JsonConverter(typeof(JsonStringConverter))]
        public string OperatorTips { get; set; }

    }
}
