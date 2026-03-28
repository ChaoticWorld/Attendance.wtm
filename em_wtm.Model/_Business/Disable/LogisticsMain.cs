using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 物流主表
/// </summary>
public partial class LogisticsMain
{
    /// <summary>
    /// 序号
    /// </summary>
    public int Lid { get; set; }

    /// <summary>
    /// 发货单号
    /// </summary>
    public string DlCode { get; set; }

    /// <summary>
    /// 物流单号
    /// </summary>
    public string LogisticsVouchCode { get; set; }

    /// <summary>
    /// 物流日期
    /// </summary>
    public DateTime? DDate { get; set; }

    /// <summary>
    /// 送货人
    /// </summary>
    public string Sender { get; set; }

    /// <summary>
    /// 收款人
    /// </summary>
    public string Payee { get; set; }

    /// <summary>
    /// 送货完成
    /// </summary>
    public bool? BSended { get; set; }

    /// <summary>
    /// 收款完成
    /// </summary>
    public bool? BPayoff { get; set; }

    /// <summary>
    /// erpDLID
    /// </summary>
    public int Dlid { get; set; }

    /// <summary>
    /// 执行状态:
    /// 分配/装车/签收/退回/收款
    /// </summary>
    public string State { get; set; }
}
