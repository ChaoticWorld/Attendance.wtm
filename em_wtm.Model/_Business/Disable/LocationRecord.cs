using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 位置记录
/// </summary>
public partial class LocationRecord
{
    /// <summary>
    /// 序号
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 经度
    /// </summary>
    public decimal? Longitude { get; set; }

    /// <summary>
    /// 纬度
    /// </summary>
    public decimal? Latitude { get; set; }

    /// <summary>
    /// 操作
    /// </summary>
    public string Action { get; set; }

    /// <summary>
    /// 模块
    /// </summary>
    public string Module { get; set; }

    /// <summary>
    /// 操作员
    /// </summary>
    public string COperator { get; set; }
}
