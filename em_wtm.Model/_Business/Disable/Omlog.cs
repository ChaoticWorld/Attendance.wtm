using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class Omlog
{
    public int Autoid { get; set; }

    public bool? BSend { get; set; }

    public DateTime? DLogDate { get; set; }

    public string COmdevice { get; set; }

    public string COmmessage { get; set; }
}
