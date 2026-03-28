using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class PuorderMain
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
}
