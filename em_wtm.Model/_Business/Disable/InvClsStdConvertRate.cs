using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class InvClsStdConvertRate
{
    public int Autoid { get; set; }

    public string InvClsName { get; set; }

    public string InvStd { get; set; } = null!;

    public decimal PriceRate { get; set; }

    public int? InvClsId { get; set; }
}
