using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class QcClass
{
    public int IClsAutoId { get; set; }

    /// <summary>
    /// 分类名
    /// </summary>
    public string CClsName { get; set; }

    /// <summary>
    /// 分类标识
    /// </summary>
    public string CClsFlag { get; set; }

    /// <summary>
    /// 当前日期
    /// </summary>
    public DateTime? DToDay { get; set; }

    /// <summary>
    /// 当天最大值
    /// </summary>
    public int? IToDayMax { get; set; }
}
