using em_wtm.Model._Business.Attendance;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2RecordVMs
{
    public partial class Attendance2RecordBatchVM : BaseBatchVM<Attendance2Record, Attendance2Record_BatchEdit>
    {
        public Attendance2RecordBatchVM()
        {
            ListVM = new Attendance2RecordListVM();
            LinkedVM = new Attendance2Record_BatchEdit();
        }

    }

    /// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Attendance2Record_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
