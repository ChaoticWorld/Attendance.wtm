using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class Omcdr
{
    public string Id { get; set; } = null!;

    public DateTime? DDate { get; set; }

    public int? Callid { get; set; }

    public int? Callerid { get; set; }

    public string Caller { get; set; }

    public string Type { get; set; }

    public string Route { get; set; }

    public string TimeStart { get; set; }

    public string TimeEnd { get; set; }

    public string Cpn { get; set; }

    public string Cdpn { get; set; }

    public int? Duration { get; set; }

    public string TrunkNumber { get; set; }

    public string Recording { get; set; }
}
