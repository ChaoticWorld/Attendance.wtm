using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 员工班次
/// </summary>
public partial class AttendanceEmployeeRefSchemeClass
{
    /// <summary>
    /// 序号
    /// </summary>
    public int Autoid { get; set; }

    /// <summary>
    /// 用户号
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// 考勤机员工ID
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// 方案班次ID
    /// </summary>
    public int ClassId { get; set; }

    /// <summary>
    /// 生效日期
    /// </summary>
    public DateTime EffDate { get; set; }

    /// <summary>
    /// 最后设定日期对应的记录周期号
    /// </summary>
    public int PeriodNo { get; set; }

    /// <summary>
    /// 失效日期
    /// </summary>
    public DateTime? ExpDate { get; set; }

    public string EmployeeName { get; set; }

    public bool? IsVaild { get; set; }
}
