using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class QcDetailClass
{
    /// <summary>
    /// 签呈分类名称
    /// </summary>
    public string QcRcname { get; set; }

    /// <summary>
    /// 签呈分类描述
    /// </summary>
    public string QcRcdescription { get; set; }

    /// <summary>
    /// 排序权重
    /// </summary>
    public int? QcRcindex { get; set; }

    public int QcRcid { get; set; }
}
