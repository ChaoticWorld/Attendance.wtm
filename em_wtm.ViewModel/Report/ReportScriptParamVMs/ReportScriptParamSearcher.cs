using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using em_wtm.Model._Business.Report;


namespace em_wtm.ViewModel.Report.ReportScriptParamVMs
{
    public partial class ReportScriptParamSearcher : BaseSearcher
    {
        public int? ReportID { get; set; }
        public int? ScriptID { get; set; }

        protected override void InitVM()
        {
        }

    }
}
