using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 网站扩展信息表
/// </summary>
public partial class HrwebPageExtendInfo
{
    /// <summary>
    /// 简历ID
    /// </summary>
    public string Resumeid { get; set; }

    /// <summary>
    /// 人员ID
    /// </summary>
    public string Infoid { get; set; }

    /// <summary>
    /// 姓名
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 电话
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string Memo { get; set; }

    /// <summary>
    /// 页面
    /// </summary>
    public string WebPage { get; set; }

    /// <summary>
    /// URL
    /// </summary>
    public string WebUri { get; set; }

    /// <summary>
    /// 性别
    /// </summary>
    public string Gender { get; set; }

    /// <summary>
    /// 出生年
    /// </summary>
    public int? BirthYear { get; set; }

    /// <summary>
    /// 序号
    /// </summary>
    public int Id { get; set; }
}
