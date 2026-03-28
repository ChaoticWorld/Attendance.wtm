using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 日志
/// </summary>
public partial class Attendance2Log
{
    /// <summary>
    /// 日志ID
    /// </summary>
    public int ILogId { get; set; }

    /// <summary>
    /// 日志日期
    /// </summary>
    public DateTime DLogDate { get; set; }

    /// <summary>
    /// 用户Id
    /// </summary>
    public int? IUserId { get; set; }

    /// <summary>
    /// 用户名
    /// </summary>
    public string CUserName { get; set; }

    /// <summary>
    /// 用户工作站
    /// </summary>
    public string CWorkStation { get; set; }

    /// <summary>
    /// 来源
    /// </summary>
    public string CSource { get; set; }

    /// <summary>
    /// 参数
    /// </summary>
    public string CParams { get; set; }

    /// <summary>
    /// 返回值
    /// </summary>
    public string CReturn { get; set; }

    /// <summary>
    /// 异常
    /// </summary>
    public string CException { get; set; }

    /// <summary>
    /// 级别
    /// </summary>
    public string CLevel { get; set; }
}
