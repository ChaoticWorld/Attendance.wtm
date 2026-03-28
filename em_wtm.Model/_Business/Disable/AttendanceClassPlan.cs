using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class AttendanceClassPlan
{
    /// <summary>
    /// 班次号
    /// </summary>
    public int? ClassId { get; set; }

    /// <summary>
    /// 周期序号，从０开始，小于０的为班次调班
    /// </summary>
    public int PeriodNo { get; set; }

    /// <summary>
    /// 上班时间字符串-hh:mm:ss.nnn
    /// </summary>
    public string BTime { get; set; }

    /// <summary>
    /// 下班时间字符串-hh:mm:ss.nnn
    /// </summary>
    public string ETime { get; set; }

    /// <summary>
    /// 计算加班起始量
    /// </summary>
    public string UpTime { get; set; }

    public int Autoid { get; set; }

    public DateTime? Sdate { get; set; }
}
