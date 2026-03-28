using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class ReportPivotView
{
    public int Autoid { get; set; }

    public int? ReportId { get; set; }

    public int? UserId { get; set; }

    public string PivotParams { get; set; }

    public string PivotName { get; set; }

    public bool? IsLast { get; set; }
}
