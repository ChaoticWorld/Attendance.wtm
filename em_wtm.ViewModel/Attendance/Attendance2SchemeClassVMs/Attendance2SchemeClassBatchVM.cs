using em_wtm.Model._Business.Attendance;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2SchemeClassVMs
{
    public partial class Attendance2SchemeClassBatchVM : BaseBatchVM<Attendance2SchemeClass, Attendance2SchemeClass_BatchEdit>
    {
        public Attendance2SchemeClassBatchVM()
        {
            ListVM = new Attendance2SchemeClassListVM();
            LinkedVM = new Attendance2SchemeClass_BatchEdit();
        }

    }

    /// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Attendance2SchemeClass_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
