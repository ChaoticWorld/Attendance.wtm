using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class ReportModule
{
    public int ModuleId { get; set; }

    public string ModuleName { get; set; } = null!;

    public string ModuleDescription { get; set; }
}
