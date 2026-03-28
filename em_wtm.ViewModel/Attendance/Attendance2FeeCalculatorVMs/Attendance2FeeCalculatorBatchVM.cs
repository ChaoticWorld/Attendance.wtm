using em_wtm.Model._Business.Attendance;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2FeeCalculatorVMs
{
    public partial class Attendance2FeeCalculatorBatchVM : BaseBatchVM<Attendance2FeeCalculator, Attendance2FeeCalculator_BatchEdit>
    {
        public Attendance2FeeCalculatorBatchVM()
        {
            ListVM = new Attendance2FeeCalculatorListVM();
            LinkedVM = new Attendance2FeeCalculator_BatchEdit();
        }

    }

    /// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Attendance2FeeCalculator_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
