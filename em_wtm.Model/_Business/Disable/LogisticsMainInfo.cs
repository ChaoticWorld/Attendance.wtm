using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 主表信息
/// </summary>
public partial class LogisticsMainInfo
{
    /// <summary>
    /// erpDLID
    /// </summary>
    public int Dlid { get; set; }

    /// <summary>
    /// DLCode
    /// </summary>
    public string DlCode { get; set; }

    /// <summary>
    /// 客户简称
    /// </summary>
    public string DwAbbName { get; set; }

    /// <summary>
    /// 客户经理
    /// </summary>
    public string EmployeeName { get; set; }

    /// <summary>
    /// 联系人
    /// </summary>
    public string ContactName { get; set; }

    /// <summary>
    /// 联系电话
    /// </summary>
    public string ContactPhone { get; set; }

    /// <summary>
    /// 地址
    /// </summary>
    public string ShipAddress { get; set; }

    /// <summary>
    /// 单据备注
    /// </summary>
    public string VouchMemo { get; set; }

    /// <summary>
    /// 单据日期
    /// </summary>
    public DateTime? DlDate { get; set; }

    /// <summary>
    /// 金额
    /// </summary>
    public decimal? Money { get; set; }
}
