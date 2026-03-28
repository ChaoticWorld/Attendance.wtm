using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class AttendanceLog
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
    /// 用户工作站
    /// </summary>
    public string CWorkStation { get; set; }

    /// <summary>
    /// 用户IP
    /// </summary>
    public string CIp { get; set; }

    /// <summary>
    /// 原值
    /// </summary>
    public string CBeforeValue { get; set; }

    /// <summary>
    /// 模块
    /// </summary>
    public string CModule { get; set; }

    /// <summary>
    /// 函数
    /// </summary>
    public string CFunction { get; set; }

    /// <summary>
    /// 参数
    /// </summary>
    public string CParams { get; set; }

    /// <summary>
    /// 类名
    /// </summary>
    public string CClass { get; set; }

    /// <summary>
    /// 返回值
    /// </summary>
    public string CReturn { get; set; }

    /// <summary>
    /// 异常
    /// </summary>
    public string CException { get; set; }

    /// <summary>
    /// 用户名
    /// </summary>
    public string CUserName { get; set; }

    /// <summary>
    /// 线程
    /// </summary>
    public string CThread { get; set; }

    /// <summary>
    /// 级别
    /// </summary>
    public string CLevel { get; set; }
}
