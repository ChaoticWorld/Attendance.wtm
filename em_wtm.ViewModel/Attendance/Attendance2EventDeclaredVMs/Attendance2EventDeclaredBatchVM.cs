using em_wtm.Model._Business.Attendance;
using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;


namespace em_wtm.ViewModel.Attendance.Attendance2EventDeclaredVMs
{
    public partial class Attendance2EventDeclaredBatchVM : BaseBatchVM<Attendance2EventDeclared, Attendance2EventDeclared_BatchEdit>
    {
        public Attendance2EventDeclaredBatchVM()
        {
            ListVM = new Attendance2EventDeclaredListVM();
            LinkedVM = new Attendance2EventDeclared_BatchEdit();
        }

    }

    /// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Attendance2EventDeclared_BatchEdit : BaseVM
    {
        [Display(Name = "审核人")]
        public String CheckMan { get; set; }
        [Display(Name = "经理签字")]
        public String Manager { get; set; }

        protected override void InitVM()
        {
        }

    }

}
