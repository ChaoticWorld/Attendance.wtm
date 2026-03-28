using em_wtm.Model._Business.Attendance;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2EventDeclaredVMs
{
    public partial class Attendance2EventDeclaredVM : BaseCRUDVM<Attendance2EventDeclared>
    {

        public Attendance2EventDeclaredVM()
        {
            SetInclude(x => x.Record);
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
