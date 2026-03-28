using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class VPurchaseOrder
{
    public int Id { get; set; }

    public string FactoryPoOrder { get; set; } = null!;

    public string BizPoOrder { get; set; }

    public DateTime? DDate { get; set; }

    public string Factory { get; set; }

    public string Area { get; set; }

    public string Consignee { get; set; }

    public string Receiver { get; set; }

    public string ReceivingAddress { get; set; }

    public string ReceivingPhone { get; set; }

    public string Memo { get; set; }

    public int? Autoid { get; set; }

    public int? PumId { get; set; }

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
