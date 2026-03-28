using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class QcCodeIdentity
{
    public int AutoId { get; set; }

    public string CClsFlag { get; set; }

    public DateTime? DDate { get; set; }

    public string CManager { get; set; }

    public int? ISn { get; set; }
}
