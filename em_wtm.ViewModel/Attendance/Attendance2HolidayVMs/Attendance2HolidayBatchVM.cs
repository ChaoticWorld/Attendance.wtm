using em_wtm.Model._Business.Attendance;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2HolidayVMs
{
    public partial class Attendance2HolidayBatchVM : BaseBatchVM<Attendance2Holiday, Attendance2Holiday_BatchEdit>
    {
        public Attendance2HolidayBatchVM()
        {
            ListVM = new Attendance2HolidayListVM();
            LinkedVM = new Attendance2Holiday_BatchEdit();
        }

    }

    /// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Attendance2Holiday_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
