using em_wtm.Model._Business.Attendance;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2PlanTimeVMs
{
    public partial class Attendance2PlanTimeBatchVM : BaseBatchVM<Attendance2PlanTime, Attendance2PlanTime_BatchEdit>
    {
        public Attendance2PlanTimeBatchVM()
        {
            ListVM = new Attendance2PlanTimeListVM();
            LinkedVM = new Attendance2PlanTime_BatchEdit();
        }

    }

    /// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Attendance2PlanTime_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
