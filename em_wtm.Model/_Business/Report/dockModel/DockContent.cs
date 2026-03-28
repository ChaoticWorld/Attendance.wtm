using System.Text.Json.Serialization;

namespace em_wtm.Model._Business.Report.dockModel;

    /// <summary>
    /// DockContent 类对标 content 配置项
    /// </summary>
    public class DockContent : DockComponentBase
{

    /// <summary>
    /// 获得/设置 组件宽度百分比 默认 null 未设置
    /// </summary>

    public int? Width { get; set; }

    /// <summary>
    /// 获得/设置 组件高度百分比 默认 null 未设置
    /// </summary>

    public int? Height { get; set; }

}
