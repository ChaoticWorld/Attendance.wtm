using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 物流子表
/// </summary>
public partial class LogisticsDetail
{
    /// <summary>
    /// 序号
    /// </summary>
    public int Autoid { get; set; }

    /// <summary>
    /// 主表序号
    /// </summary>
    public int Lid { get; set; }

    /// <summary>
    /// 存货编码
    /// </summary>
    public string InvCode { get; set; }

    /// <summary>
    /// 存货名称
    /// </summary>
    public string InvName { get; set; }

    /// <summary>
    /// 存货型号
    /// </summary>
    public string InvStd { get; set; }

    /// <summary>
    /// 单据数量
    /// </summary>
    public decimal? DlQuantity { get; set; }

    /// <summary>
    /// 收货数量
    /// </summary>
    public decimal? ReceivQuantity { get; set; }

    /// <summary>
    /// 收货差异原因
    /// </summary>
    public string ReceivDifferenceReason { get; set; }

    /// <summary>
    /// 送货人
    /// </summary>
    public string Sender { get; set; }

    /// <summary>
    /// 送货人ID
    /// </summary>
    public int? SenderId { get; set; }

    /// <summary>
    /// erpDLidlsid
    /// </summary>
    public int Idlsid { get; set; }

    /// <summary>
    /// erpDLID
    /// </summary>
    public int Dlid { get; set; }

    /// <summary>
    /// 装车数量
    /// </summary>
    public decimal? ShipQuantity { get; set; }

    /// <summary>
    /// 装车差异原因
    /// </summary>
    public string ShipDifferenceReason { get; set; }
}
