using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class ReportPermission
{
    public int AutoId { get; set; }

    public int? ReportId { get; set; }

    public int? UserId { get; set; }
}
