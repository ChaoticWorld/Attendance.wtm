using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class TaxRefErp
{
    /// <summary>
    /// 发票主表ID
    /// </summary>
    public int TaxId { get; set; }

    /// <summary>
    /// ERP单据编码
    /// </summary>
    public string ErpCode { get; set; }

    /// <summary>
    /// ERP单据金额
    /// </summary>
    public decimal? ErpJe { get; set; }

    /// <summary>
    /// ERP客户名称
    /// </summary>
    public string ErpCusName { get; set; }

    /// <summary>
    /// ERP单据日期
    /// </summary>
    public DateTime? ErpDate { get; set; }

    /// <summary>
    /// ERP客户简称
    /// </summary>
    public string ErpCusAbbName { get; set; }

    /// <summary>
    /// ERP联系人
    /// </summary>
    public string ErpCusContact { get; set; }

    /// <summary>
    /// ERP单据类型
    /// </summary>
    public string ErpVouchType { get; set; }

    /// <summary>
    /// 发票备注ERP单据简码
    /// </summary>
    public string TaxErpCode { get; set; }

    /// <summary>
    /// ERP主表ID
    /// </summary>
    public int? ErpMainId { get; set; }

    /// <summary>
    /// 核销
    /// </summary>
    public bool? BVerification { get; set; }

    /// <summary>
    /// 发票日期
    /// </summary>
    public DateTime? TaxDate { get; set; }

    /// <summary>
    /// 发票编码
    /// </summary>
    public string Fphm { get; set; }
}
