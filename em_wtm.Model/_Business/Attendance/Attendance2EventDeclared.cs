using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace em_wtm.Model._Business.Attendance
{
    [Table("Attendance2_EventDeclared")]
    [Display(Name = "考勤事件")]
    public partial class Attendance2EventDeclared : TopBasePoco
    {
        /// <summary>
        /// 事件序号
        /// </summary>
        [Display(Name = "序号")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("EventId")]
        public new int ID { get; set; }

        /// <summary>
        /// 事件描述
        /// </summary>
        [Display(Name = "事件描述")]
        public string EventDescription { get; set; }

        /// <summary>
        /// 其它费用
        /// </summary>
        [Display(Name = "费用")]
        public decimal? Fee { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Memo { get; set; }

        /// <summary>
        /// 审核人
        /// </summary>
        [Display(Name = "审核人")]
        public string CheckMan { get; set; }

        /// <summary>
        /// 经理签字
        /// </summary>
        [Display(Name = "经理签字")]
        public string Manager { get; set; }

        [Display(Name = "考勤记录")]
        [Column("RecordId")]
        public int RecordId { get; set; }
        public Attendance2Record Record { get; set; }

        [Display(Name = "是否上班考勤事件")]
        public bool IsBeginTime { get; set; }
    }
}