using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 物流企业
/// </summary>
public partial class LogisticsEnterprise
{
    /// <summary>
    /// 序号
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 名称
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 简称
    /// </summary>
    public string AbbName { get; set; }

    /// <summary>
    /// 联系人
    /// </summary>
    public string ContentName { get; set; }

    /// <summary>
    /// 联系电话
    /// </summary>
    public string ContentPhone { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string Memo { get; set; }

    /// <summary>
    /// 企业前缀
    /// </summary>
    public string PreCode { get; set; }

    /// <summary>
    /// 默认车牌号
    /// </summary>
    public string DefaultTruckNumber { get; set; }

    /// <summary>
    /// 默认随车电话
    /// </summary>
    public string DefaultTruckPhone { get; set; }
}
