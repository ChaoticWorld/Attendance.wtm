using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class TaxBillDetail
{
    public int Autoid { get; set; }

    /// <summary>
    /// 发票主表ID
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// 序号
    /// </summary>
    public int? Xh { get; set; }

    /// <summary>
    /// 商品名称
    /// </summary>
    public string Spmc { get; set; }

    /// <summary>
    /// 规格型号
    /// </summary>
    public string Ggxh { get; set; }

    /// <summary>
    /// 计量单位
    /// </summary>
    public string Jldw { get; set; }

    /// <summary>
    /// 单价
    /// </summary>
    public decimal? Dj { get; set; }

    /// <summary>
    /// 数量
    /// </summary>
    public decimal? Sl { get; set; }

    /// <summary>
    /// 金额
    /// </summary>
    public decimal? Je { get; set; }

    /// <summary>
    /// 税率
    /// </summary>
    public decimal? Slv { get; set; }

    /// <summary>
    /// 税额
    /// </summary>
    public decimal? Se { get; set; }

    /// <summary>
    /// 商品编码
    /// </summary>
    public string Spbm { get; set; }

    /// <summary>
    /// 企业商品编码
    /// </summary>
    public string Qyspbm { get; set; }

    /// <summary>
    /// 优惠政策标识
    /// </summary>
    public int? Syyhzcbz { get; set; }

    /// <summary>
    /// 零税率标识
    /// </summary>
    public string Lslbz { get; set; }

    /// <summary>
    /// 优惠政策说明
    /// </summary>
    public string Yhzcsm { get; set; }
}
