using em_wtm.Model._Business.Attendance;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2RecordVMs
{
    public partial class Attendance2RecordVM : BaseCRUDVM<Attendance2Record>
    {

        public Attendance2RecordVM()
        {
            SetInclude(x => x.Employee);
            SetInclude(x => x.DayType);
            SetInclude(x => x.Plan);
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
