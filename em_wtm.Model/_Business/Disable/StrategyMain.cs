using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class StrategyMain
{
    public int Id { get; set; }

    public string CDwcode { get; set; }

    public string CDwname { get; set; }

    public string CDwcontact { get; set; }

    public DateTime? DEffDate { get; set; }

    public DateTime? DExpDate { get; set; }

    public string CMemo { get; set; }

    public string CDcname { get; set; }

    public string CSourceCode { get; set; }

    public string CSourceType { get; set; } = null!;

    public string CLevel { get; set; } = null!;

    public string CVouchCode { get; set; }

    public string CVouchType { get; set; }

    public string CModifier { get; set; }
}
