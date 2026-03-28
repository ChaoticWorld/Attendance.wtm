using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace em_wtm.Model._Business.Attendance
{
    [Table("V_AttendanceEmployee")]
    [Display(Name = "员工表")]
    public partial class VAttendanceEmployee : TopBasePoco
    {
        [Display(Name = "序号")]
        [Key]
        [Column("EmployeeId")]
        public new int ID { get; set; }

        [Display(Name = "员工姓名")]
        public string EmployeeName { get; set; } = null!;
    }
}
