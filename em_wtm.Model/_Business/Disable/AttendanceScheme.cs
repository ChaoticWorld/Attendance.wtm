using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class AttendanceScheme
{
    /// <summary>
    /// 方案号
    /// </summary>
    public int SchemeId { get; set; }

    /// <summary>
    /// 方案名
    /// </summary>
    public string SchemeName { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string SchemeDescription { get; set; }

    /// <summary>
    /// 周期数
    /// </summary>
    public int? Periods { get; set; }

    /// <summary>
    /// 班次数
    /// </summary>
    public int? Classs { get; set; }
}
