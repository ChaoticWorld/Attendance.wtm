using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class PhoneEnterprise
{
    /// <summary>
    /// 企业ID
    /// </summary>
    public int EnterpriseId { get; set; }

    /// <summary>
    /// 编码
    /// </summary>
    public string EnterpriseCode { get; set; }

    /// <summary>
    /// 名称
    /// </summary>
    public string EnterpriseName { get; set; }

    /// <summary>
    /// 简称
    /// </summary>
    public string EnterpriseAbbName { get; set; }

    /// <summary>
    /// 地址
    /// </summary>
    public string EnterpriseAddress { get; set; }

    /// <summary>
    /// 信息代码
    /// </summary>
    public string EnterpriseNumber { get; set; }

    /// <summary>
    /// 产品
    /// </summary>
    public string EnterpriseProduct { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string EnterpriseMemo { get; set; }

    /// <summary>
    /// 类型
    /// </summary>
    public string EnterpriseType { get; set; }
}
