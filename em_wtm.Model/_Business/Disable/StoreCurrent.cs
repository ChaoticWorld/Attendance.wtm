using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class StoreCurrent
{
    public int Autoid { get; set; }

    public string InventoryCode { get; set; }

    public string WarehouseCode { get; set; }

    public decimal? Iquantity { get; set; }
}
