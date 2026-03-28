using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class Omevent
{
    public int Autoid { get; set; }

    public DateTime? DDate { get; set; }

    public string Attribute { get; set; }

    public int? Extid { get; set; }

    public string Caller { get; set; }

    public int? Callid { get; set; }

    public string From { get; set; }

    public string To { get; set; }

    public string Trunk { get; set; }

    public string Reason { get; set; }

    public int? Extid2 { get; set; }

    public int? Callerid { get; set; }
}
