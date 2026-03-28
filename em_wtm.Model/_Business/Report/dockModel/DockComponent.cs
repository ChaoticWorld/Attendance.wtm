// Copyr
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace em_wtm.Model._Business.Report.dockModel;
/// <summary>
/// DockContentItem 配置项子项对标 content 配置项内部 content 配置
/// </summary>
public class DockComponent : DockComponentBase
{
    /// <summary>
    /// 获得/设置 组件名称 默认 component
    /// </summary>

    public string ComponentName { get; set; } = "component";

    /// <summary>
    /// 获得/设置 组件 Title
    /// </summary>

    public string? Title { get; set; }

    /// <summary>
    /// 获得/设置 组件 Class
    /// </summary>

    public string? Class { get; set; }

    /// <summary>
    /// 获得/设置 组件是否可见 默认 true 可见
    /// </summary>

    public bool Visible { get; set; } = true;

    /// <summary>
    /// 获得/设置 组件是否允许关闭 默认 true
    /// </summary>

    public bool ShowClose { get; set; } = true;

    /// <summary>
    /// 获得/设置 组件宽度百分比 默认 null 未设置
    /// </summary>

    public int? Width { get; set; }

    /// <summary>
    /// 获得/设置 组件高度百分比 默认 null 未设置
    /// </summary>

    public int? Height { get; set; }

    /// <summary>
    /// 获得/设置 组件唯一标识值 默认 null 未设置时取 Title 作为唯一标识
    /// </summary>

    public string? Key { get; set; }

    /// <summary>
    /// 获得/设置 组件状态
    /// </summary>
    [NotMapped]
    public object? ComponentState { get; set; }

    /// <summary>
    /// 获得/设置 是否锁定 默认 false
    /// </summary>
    /// <remarks>锁定后无法拖动</remarks>

    [JsonIgnore]
    public bool IsLock { get; set; }


    /// <summary>
    /// 设置 Visible 参数方法
    /// </summary>
    /// <param name="visible"></param>
    public void SetVisible(bool visible)
    {
        Visible = visible;
    }
}
