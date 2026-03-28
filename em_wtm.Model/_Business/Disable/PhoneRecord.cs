using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class PhoneRecord
{
    /// <summary>
    /// 通信记录ID
    /// </summary>
    public int Autoid { get; set; }

    /// <summary>
    /// 联系人
    /// </summary>
    public string ContactName { get; set; }

    /// <summary>
    /// 通信号码
    /// </summary>
    public string CommNumber { get; set; }

    /// <summary>
    /// 呼入:0,呼出:1
    /// </summary>
    public bool? CommOut { get; set; }

    /// <summary>
    /// 日期时间
    /// </summary>
    public DateTime? CommDate { get; set; }

    /// <summary>
    /// 内容
    /// </summary>
    public string CommContent { get; set; }

    /// <summary>
    /// 关联企业
    /// </summary>
    public string ContactRefEnterprise { get; set; }
}
