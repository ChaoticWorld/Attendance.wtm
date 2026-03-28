using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class Phone2User
{
    /// <summary>
    /// 通道ID
    /// </summary>
    public int ChId { get; set; }

    /// <summary>
    /// 电话号码
    /// </summary>
    public int? PhoneNumber { get; set; }

    /// <summary>
    /// 用户ID
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// IP地址
    /// </summary>
    public string UserIp { get; set; }
}
