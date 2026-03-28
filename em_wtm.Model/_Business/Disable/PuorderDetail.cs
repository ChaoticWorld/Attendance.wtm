using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class PuorderDetail
{
    public int Autoid { get; set; }

    public int? Id { get; set; }

    public string InvCode { get; set; }

    public string InvName { get; set; }

    public string InvStd { get; set; }

    public int? Pack { get; set; }

    public decimal? Poquantity { get; set; }

    public decimal? Poprice { get; set; }

    public decimal? Pomoney { get; set; }

    public decimal? Poweight { get; set; }

    public int? InvLayer { get; set; }

    public int? InvDiv { get; set; }

    public int? OrderId { get; set; }

    public string InvBrand { get; set; }

    public string InvLevel { get; set; }
}
