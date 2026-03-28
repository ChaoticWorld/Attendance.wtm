using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2PlanRefClassVMs
{
    public partial class Attendance2PlanRefClassSearcher : BaseSearcher
    {
        public int? ClassId { get; set; }
        public int? PlanId { get; set; }

        protected override void InitVM()
        {
        }

    }
}
