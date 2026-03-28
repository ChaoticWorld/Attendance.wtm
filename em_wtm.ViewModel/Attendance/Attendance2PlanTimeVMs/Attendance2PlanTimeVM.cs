using em_wtm.Model._Business.Attendance;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2PlanTimeVMs
{
    public partial class Attendance2PlanTimeVM : BaseCRUDVM<Attendance2PlanTime>
    {

        public Attendance2PlanTimeVM()
        {
            SetInclude(x => x.DayType);
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
