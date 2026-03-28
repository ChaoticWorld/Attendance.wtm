using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace em_wtm.Model._Business.Report
{
    [Table("Report_Permissions")]
    [Display(Name = "报表权限")]
    public partial class ReportPermission : TopBasePoco
    {
        [Key]
        [Display(Name = "权限ID")]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public new int ID { get; set; }
        [Display(Name = "报表ID")]
        public int? ReportId { get; set; }
        public ReportMain Report {  get; set; }
        [Display(Name = "用户ID")]
        public Guid UserId { get; set; }
        public FrameworkUser User { get; set; }
    }
}
