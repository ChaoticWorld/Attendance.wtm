using em_wtm.Model._Business.Attendance;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2PlanRefClassVMs
{
    public partial class Attendance2PlanRefClassVM : BaseCRUDVM<Attendance2PlanRefClass>
    {

        public Attendance2PlanRefClassVM()
        {
            SetInclude(x => x.Class);
            SetInclude(x => x.Plan);
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
