using em_wtm.Model._Business.Attendance;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2EmployeeRefSchemeClassVMs
{
    public partial class Attendance2EmployeeRefSchemeClassBatchVM : BaseBatchVM<Attendance2EmployeeRefSchemeClass, Attendance2EmployeeRefSchemeClass_BatchEdit>
    {
        public Attendance2EmployeeRefSchemeClassBatchVM()
        {
            ListVM = new Attendance2EmployeeRefSchemeClassListVM();
            LinkedVM = new Attendance2EmployeeRefSchemeClass_BatchEdit();
        }

    }

    /// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Attendance2EmployeeRefSchemeClass_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
