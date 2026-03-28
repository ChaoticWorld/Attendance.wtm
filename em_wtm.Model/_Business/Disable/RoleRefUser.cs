using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 角色关联用户
/// </summary>
public partial class RoleRefUser
{
    /// <summary>
    /// 1
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 角色ID
    /// </summary>
    public int RoleId { get; set; }

    /// <summary>
    /// 用户ID
    /// </summary>
    public int UserId { get; set; }
}
