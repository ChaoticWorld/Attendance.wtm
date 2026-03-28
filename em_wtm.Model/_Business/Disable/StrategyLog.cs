using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class StrategyLog
{
    /// <summary>
    /// 日志ID
    /// </summary>
    public long ILogId { get; set; }

    /// <summary>
    /// 日志日期
    /// </summary>
    public DateTime DLogDate { get; set; }

    /// <summary>
    /// 用户Id
    /// </summary>
    public int? IUserId { get; set; }

    /// <summary>
    /// 用户工作站
    /// </summary>
    public string CWorkStation { get; set; }

    /// <summary>
    /// 用户IP
    /// </summary>
    public string CIp { get; set; }

    /// <summary>
    /// 功能Id
    /// </summary>
    public int? IFunctionId { get; set; }

    /// <summary>
    /// 动作Id
    /// </summary>
    public int? IActionId { get; set; }

    /// <summary>
    /// 修改后的值
    /// </summary>
    public string CLastValue { get; set; }

    public string CModule { get; set; }

    public string CFunction { get; set; }

    public string CParams { get; set; }

    public string CClass { get; set; }

    public string CReturn { get; set; }

    public string CException { get; set; }

    public string CUserName { get; set; }
}
