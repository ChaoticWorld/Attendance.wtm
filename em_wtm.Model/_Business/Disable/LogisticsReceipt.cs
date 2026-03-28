using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 收款表
/// </summary>
public partial class LogisticsReceipt
{
    /// <summary>
    /// 应收序号
    /// </summary>
    public int ArId { get; set; }

    /// <summary>
    /// 发货单号
    /// </summary>
    public string DlCode { get; set; }

    /// <summary>
    /// 日期
    /// </summary>
    public DateTime? DDate { get; set; }

    /// <summary>
    /// 发货金额
    /// </summary>
    public decimal? DlMoney { get; set; }

    /// <summary>
    /// 收款金额
    /// </summary>
    public decimal? CollectionMoney { get; set; }

    /// <summary>
    /// 差异原因
    /// </summary>
    public string DifferenceReason { get; set; }

    /// <summary>
    /// 收款人
    /// </summary>
    public string Payee { get; set; }

    /// <summary>
    /// 收款人ID
    /// </summary>
    public int? PayeeId { get; set; }

    /// <summary>
    /// 发货单dlid
    /// </summary>
    public int? Dlid { get; set; }

    /// <summary>
    /// 收款方式
    /// </summary>
    public string PayMethod { get; set; }
}
