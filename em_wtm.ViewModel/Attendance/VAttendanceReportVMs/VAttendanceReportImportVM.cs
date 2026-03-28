using em_wtm.Model._Business.Attendance;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.VAttendanceReportVMs
{
    public partial class VAttendanceReportTemplateVM : BaseTemplateVM
    {

        protected override void InitVM()
        {
        }

    }

    public class VAttendanceReportImportVM : BaseImportVM<VAttendanceReportTemplateVM, VAttendanceReport>
    {

    }

}
