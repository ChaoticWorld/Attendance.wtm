using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class Pudispatch
{
    public int Id { get; set; }

    public string DispatchId { get; set; }

    public decimal? DispatchQuantity { get; set; }

    public decimal? DispatchWeight { get; set; }

    public decimal? DispatchMoney { get; set; }

    public int? PodId { get; set; }
}
