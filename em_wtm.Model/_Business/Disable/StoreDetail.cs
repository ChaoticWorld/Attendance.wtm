using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class StoreDetail
{
    public int DId { get; set; }

    public int? MId { get; set; }

    public string CInvCode { get; set; }

    public decimal? IQuantity { get; set; }

    public string CWhcode { get; set; }

    public string CMemo { get; set; }
}
