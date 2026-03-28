using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 操作人员表
/// </summary>
public partial class LogisticsOperator
{
    /// <summary>
    /// 操作员编码
    /// </summary>
    public string OperatorId { get; set; } = null!;

    /// <summary>
    /// 操作员姓名
    /// </summary>
    public string OperatorName { get; set; } = null!;

    /// <summary>
    /// 电话
    /// </summary>
    public string OperatorPhone { get; set; }

    /// <summary>
    /// 是否送货人
    /// </summary>
    public bool? IsSender { get; set; }

    /// <summary>
    /// 是否库管
    /// </summary>
    public bool? IsWarehouseManager { get; set; }

    /// <summary>
    /// 是否收款人
    /// </summary>
    public bool? IsPayee { get; set; }

    /// <summary>
    /// 显示排序
    /// </summary>
    public short? OrderIndex { get; set; }
}
