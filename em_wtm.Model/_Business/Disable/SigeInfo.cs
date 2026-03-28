using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 登录信息
/// </summary>
public partial class SigeInfo
{
    /// <summary>
    /// 1
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 用户名
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 昵称
    /// </summary>
    public string NickName { get; set; }

    /// <summary>
    /// pw
    /// </summary>
    public string Pw { get; set; } = null!;

    /// <summary>
    /// email
    /// </summary>
    public string EMail { get; set; }

    /// <summary>
    /// phone
    /// </summary>
    public string Phone { get; set; }
}
