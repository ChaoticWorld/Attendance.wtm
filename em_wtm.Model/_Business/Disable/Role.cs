using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 角色
/// </summary>
public partial class Role
{
    /// <summary>
    /// 1
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 角色名
    /// </summary>
    public string RoleName { get; set; } = null!;

    /// <summary>
    /// 角色描述
    /// </summary>
    public string RoleDescription { get; set; }
}
