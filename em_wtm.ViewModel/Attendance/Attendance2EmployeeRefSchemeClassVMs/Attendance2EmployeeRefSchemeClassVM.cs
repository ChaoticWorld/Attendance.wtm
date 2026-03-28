using em_wtm.Model._Business.Attendance;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2EmployeeRefSchemeClassVMs
{
    public partial class Attendance2EmployeeRefSchemeClassVM : BaseCRUDVM<Attendance2EmployeeRefSchemeClass>
    {

        public Attendance2EmployeeRefSchemeClassVM()
        {
            SetInclude(x => x.User);
            SetInclude(x => x.Class);
        }

        protected override void InitVM()
        {
        }

        public override void DoAdd()
        {
            base.DoAdd();
        }

        public override void DoEdit(bool updateAllFields = false)
        {
            base.DoEdit(updateAllFields);
        }

        public override void DoDelete()
        {
            base.DoDelete();
        }
    }
}
