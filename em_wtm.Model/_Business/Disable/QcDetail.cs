using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class QcDetail
{
    /// <summary>
    /// 签呈记录id
    /// </summary>
    public int QcAutoid { get; set; }

    public int? QcRcid { get; set; }

    public string QcOrderCode { get; set; }

    public string CInvCode { get; set; }

    public string CInvName { get; set; }

    public string CInvStd { get; set; }

    public decimal? IQuentity { get; set; }

    public decimal? IPrice { get; set; }

    public decimal? ISum { get; set; }

    /// <summary>
    /// Memo
    /// </summary>
    public string CMemo { get; set; }

    public bool? BDaiShouKuan { get; set; }

    public int? QcMainId { get; set; }

    public DateTime? DSaleSumStartDate { get; set; }

    public DateTime? DSaleSumFinishDate { get; set; }
}
