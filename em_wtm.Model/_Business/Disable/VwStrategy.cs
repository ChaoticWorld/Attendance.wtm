using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class VwStrategy
{
    public int Id { get; set; }

    public string CDwcode { get; set; }

    public string CDwname { get; set; }

    public string CDwcontact { get; set; }

    public DateTime? DEffDate { get; set; }

    public DateTime? DExpDate { get; set; }

    public string CMemo { get; set; }

    public string CDcname { get; set; }

    public string CVouchCode { get; set; }

    public string CVouchType { get; set; }

    public string CSourceCode { get; set; }

    public string CSourceType { get; set; } = null!;

    public string CLevel { get; set; } = null!;

    public int? Autoid { get; set; }

    public string CinvAcode { get; set; }

    public string CinvAname { get; set; }

    public string CinvAstd { get; set; }

    public decimal? InvAprice { get; set; }

    public decimal? InvAquantity { get; set; }

    public decimal? InvArate { get; set; }

    public string CinvBcode { get; set; }

    public string CinvBname { get; set; }

    public string CinvBstd { get; set; }

    public decimal? InvBprice { get; set; }

    public decimal? InvBquantity { get; set; }

    public decimal? InvBrate { get; set; }

    public int? Mid { get; set; }
}
