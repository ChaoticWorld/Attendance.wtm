using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class StrategyDetail
{
    public int Autoid { get; set; }

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

    public int? Id { get; set; }
}
