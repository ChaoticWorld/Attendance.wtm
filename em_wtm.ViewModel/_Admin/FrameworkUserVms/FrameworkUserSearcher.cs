
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using em_wtm.Model;
namespace em_wtm.ViewModel._Admin.FrameworkUserVMs
{
    public partial class FrameworkUserSearcher : BaseSearcher
    {
        
        [Display(Name = "_Model._FrameworkUser._ITCode")]
        public string ITCode { get; set; }
        [Display(Name = "_Model._FrameworkUser._Name")]
        public string Name { get; set; }

        protected override void InitVM()
        {
            
        }
    }

}