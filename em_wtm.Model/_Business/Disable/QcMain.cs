using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class QcMain
{
    public int Id { get; set; }

    /// <summary>
    /// 签呈编号
    /// </summary>
    public string CCode { get; set; }

    /// <summary>
    /// 创建人
    /// </summary>
    public string CCreateMan { get; set; }

    /// <summary>
    /// 创建日期
    /// </summary>
    public DateTime? DCreateDate { get; set; }

    /// <summary>
    /// 客户经理
    /// </summary>
    public string CCusManager { get; set; }

    /// <summary>
    /// 修改人
    /// </summary>
    public string CModifyMan { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime? DModifyDate { get; set; }

    public string CCusCode { get; set; }

    public string CCusName { get; set; }

    public string CCusPerson { get; set; }

    /// <summary>
    /// 失效期
    /// </summary>
    public DateTime? DExpDate { get; set; }

    public DateTime? DEffDate { get; set; }

    public string CMemo { get; set; }

    public string CResult { get; set; }

    /// <summary>
    /// 主题
    /// </summary>
    public string CSubject { get; set; }

    public string CVouchCode { get; set; }

    public string CClsFlag { get; set; }
}
