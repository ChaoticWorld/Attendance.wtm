using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 权限关联角色
/// </summary>
public partial class PermRefRole
{
    /// <summary>
    /// 1
    /// </summary>
    public int Id { get; set; }

    public int PermissionId { get; set; }

    public int RoleId { get; set; }
}
