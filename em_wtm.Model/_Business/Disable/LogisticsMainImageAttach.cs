using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 物流单据附加图片
/// </summary>
public partial class LogisticsMainImageAttach
{
    /// <summary>
    /// 物流主表id
    /// </summary>
    public int Lid { get; set; }

    /// <summary>
    /// 附加说明
    /// </summary>
    public string AttachDescription { get; set; } = null!;

    /// <summary>
    /// 附加图片
    /// </summary>
    public byte[] AttachImage { get; set; }
}
