using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// Meta
/// </summary>
public partial class Metum
{
    /// <summary>
    /// 1
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 来自哪个表的Meta
    /// </summary>
    public string From { get; set; } = null!;

    /// <summary>
    /// title
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 需要认证
    /// </summary>
    public bool? RequiresAuth { get; set; }

    /// <summary>
    /// 图标
    /// </summary>
    public string Icon { get; set; }

    /// <summary>
    /// 自定义图标
    /// </summary>
    public string CustomIcon { get; set; }

    /// <summary>
    /// order
    /// </summary>
    public int? Order { get; set; }

    /// <summary>
    /// href
    /// </summary>
    public string Href { get; set; }

    /// <summary>
    /// singleLayout
    /// </summary>
    public string SingleLayout { get; set; }

    /// <summary>
    /// hide
    /// </summary>
    public bool? Hide { get; set; }

    /// <summary>
    /// activeMenu
    /// </summary>
    public string ActiveMenu { get; set; }

    /// <summary>
    /// mulitTab
    /// </summary>
    public bool? MulitTab { get; set; }
}
