using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 用户信息
/// </summary>
public partial class UserInfo
{
    /// <summary>
    /// 1
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 登录id
    /// </summary>
    public int? SignId { get; set; }

    /// <summary>
    /// 性别
    /// </summary>
    public bool? Male { get; set; }

    /// <summary>
    /// 证件号
    /// </summary>
    public string CardId { get; set; }

    /// <summary>
    /// 联系方式
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string Memo { get; set; }

    /// <summary>
    /// email
    /// </summary>
    public string Email { get; set; }
}
