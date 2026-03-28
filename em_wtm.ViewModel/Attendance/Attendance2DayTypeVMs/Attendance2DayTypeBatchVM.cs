using em_wtm.Model._Business.Attendance;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2DayTypeVMs
{
    public partial class Attendance2DayTypeBatchVM : BaseBatchVM<Attendance2DayType, Attendance2DayType_BatchEdit>
    {
        public Attendance2DayTypeBatchVM()
        {
            ListVM = new Attendance2DayTypeListVM();
            LinkedVM = new Attendance2DayType_BatchEdit();
        }

    }

    /// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Attendance2DayType_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
