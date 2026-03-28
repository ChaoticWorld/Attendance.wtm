using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 原因表
/// </summary>
public partial class LogisticsEnumReason
{
    /// <summary>
    /// 原因序号
    /// </summary>
    public int ReasonId { get; set; }

    /// <summary>
    /// 类型
    /// </summary>
    public string ReasonType { get; set; }

    /// <summary>
    /// 原因
    /// </summary>
    public string Reason { get; set; }
}
