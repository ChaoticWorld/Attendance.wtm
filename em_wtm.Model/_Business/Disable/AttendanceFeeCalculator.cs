using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class AttendanceFeeCalculator
{
    /// <summary>
    /// 序号
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 计费单位(分钟)
    /// </summary>
    public int? Unit { get; set; }

    /// <summary>
    /// 单位时间费用
    /// </summary>
    public decimal? UnitFee { get; set; }

    /// <summary>
    /// 费用最大值
    /// </summary>
    public decimal? MaxFee { get; set; }

    /// <summary>
    /// 班次Id
    /// </summary>
    public int? ClassId { get; set; }

    public string DateEnum { get; set; }
}
