using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class TaxEairesult
{
    /// <summary>
    /// 发票号码
    /// </summary>
    public string TaxFphm { get; set; } = null!;

    /// <summary>
    /// 发票代码
    /// </summary>
    public string TaxLbdm { get; set; }

    /// <summary>
    /// 处理时间
    /// </summary>
    public DateTime DDate { get; set; }

    /// <summary>
    /// 导入状态码
    /// </summary>
    public int? EaiState { get; set; }

    /// <summary>
    /// 导入结果
    /// </summary>
    public string EaiResult { get; set; }
}
