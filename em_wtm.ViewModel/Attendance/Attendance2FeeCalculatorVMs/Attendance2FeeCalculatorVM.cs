using em_wtm.Model._Business.Attendance;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2FeeCalculatorVMs
{
    public partial class Attendance2FeeCalculatorVM : BaseCRUDVM<Attendance2FeeCalculator>
    {

        public Attendance2FeeCalculatorVM()
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
