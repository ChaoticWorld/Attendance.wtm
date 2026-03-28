using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 权限
/// </summary>
public partial class Permission
{
    /// <summary>
    /// 1
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 权限名
    /// </summary>
    public string PermissionName { get; set; } = null!;

    /// <summary>
    /// 描述
    /// </summary>
    public string PermissionDescription { get; set; }

    /// <summary>
    /// 路径
    /// </summary>
    public string Path { get; set; } = null!;

    /// <summary>
    /// 组件
    /// </summary>
    public string Component { get; set; }

    /// <summary>
    /// 父权限Id
    /// </summary>
    public int? ParentPermissionId { get; set; }

    /// <summary>
    /// metaId
    /// </summary>
    public int? MetaId { get; set; }
}
