using em_wtm.Model._Business.Attendance;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.VAttendanceReportVMs
{
    public partial class VAttendanceReportBatchVM : BaseBatchVM<VAttendanceReport, VAttendanceReport_BatchEdit>
    {
        public VAttendanceReportBatchVM()
        {
            ListVM = new VAttendanceReportListVM();
            LinkedVM = new VAttendanceReport_BatchEdit();
        }

    }

    /// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class VAttendanceReport_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
