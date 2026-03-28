using em_wtm.Model._Business.Attendance;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2PlanRefClassVMs
{
    public partial class Attendance2PlanRefClassBatchVM : BaseBatchVM<Attendance2PlanRefClass, Attendance2PlanRefClass_BatchEdit>
    {
        public Attendance2PlanRefClassBatchVM()
        {
            ListVM = new Attendance2PlanRefClassListVM();
            LinkedVM = new Attendance2PlanRefClass_BatchEdit();
        }

    }

    /// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Attendance2PlanRefClass_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
