using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class TaxBillMain
{
    public int Id { get; set; }

    /// <summary>
    /// 单据号
    /// </summary>
    public string Djh { get; set; }

    /// <summary>
    /// 发票种类
    /// </summary>
    public string Fpzl { get; set; }

    /// <summary>
    /// 类别代码
    /// </summary>
    public string Lbdm { get; set; }

    /// <summary>
    /// 发票号码
    /// </summary>
    public string Fphm { get; set; }

    /// <summary>
    /// 开票日期
    /// </summary>
    public DateTime? Kprq { get; set; }

    /// <summary>
    /// 购方名称
    /// </summary>
    public string Gfmc { get; set; }

    /// <summary>
    /// 购方税号
    /// </summary>
    public string Gfsh { get; set; }

    /// <summary>
    /// 购方银行帐号
    /// </summary>
    public string Gfyhzh { get; set; }

    /// <summary>
    /// 购方地址电话
    /// </summary>
    public string Gfdzdh { get; set; }

    /// <summary>
    /// 销方名称
    /// </summary>
    public string Xfmc { get; set; }

    /// <summary>
    /// 销方税号
    /// </summary>
    public string Xfsh { get; set; }

    /// <summary>
    /// 销方银行帐号
    /// </summary>
    public string Xfyhzh { get; set; }

    /// <summary>
    /// 销方地址电话
    /// </summary>
    public string Xfdzdh { get; set; }

    /// <summary>
    /// 合计金额
    /// </summary>
    public decimal? Hjje { get; set; }

    /// <summary>
    /// 合计税额
    /// </summary>
    public decimal? Hjse { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string Bz { get; set; }

    /// <summary>
    /// 开票人
    /// </summary>
    public string Kpr { get; set; }

    /// <summary>
    /// 复核人
    /// </summary>
    public string Fhr { get; set; }

    /// <summary>
    /// 收款人
    /// </summary>
    public string Skr { get; set; }

    /// <summary>
    /// 商品编码版本号
    /// </summary>
    public string Spbmbbh { get; set; }

    /// <summary>
    /// 含税标志
    /// </summary>
    public int? Hsbz { get; set; }

    /// <summary>
    /// 作废标志
    /// </summary>
    public bool? Zfbz { get; set; }
}
