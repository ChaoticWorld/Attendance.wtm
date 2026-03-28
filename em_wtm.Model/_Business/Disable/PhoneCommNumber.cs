using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class PhoneCommNumber
{
    /// <summary>
    /// 通信ID
    /// </summary>
    public int CommId { get; set; }

    /// <summary>
    /// 联系人ID
    /// </summary>
    public int? ContactId { get; set; }

    /// <summary>
    /// 通信号码
    /// </summary>
    public string CommCode { get; set; }

    /// <summary>
    /// 最后通信时间
    /// </summary>
    public DateTime? CommLastDate { get; set; }
}
