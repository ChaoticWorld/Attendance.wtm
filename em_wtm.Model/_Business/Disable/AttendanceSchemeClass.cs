using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class AttendanceSchemeClass
{
    /// <summary>
    /// 方案号
    /// </summary>
    public int? SchemeId { get; set; }

    /// <summary>
    /// 班次名
    /// </summary>
    public string ClassName { get; set; }

    /// <summary>
    /// 班次id
    /// </summary>
    public int ClassId { get; set; }

    /// <summary>
    /// 排班数
    /// </summary>
    public int? Periods { get; set; }

    /// <summary>
    /// 班次描述
    /// </summary>
    public string ClassDescription { get; set; }
}
