using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class SqlQuery
{
    /// <summary>
    /// 序号
    /// </summary>
    public int Autoid { get; set; }

    /// <summary>
    /// 查询名称
    /// </summary>
    public string SQueryName { get; set; }

    /// <summary>
    /// 查寻主句, 替换关键字{0}
    /// </summary>
    public string SQueryMain { get; set; }

    /// <summary>
    /// 查寻条件, 替换关键字{0}
    /// </summary>
    public string SQueryWhere { get; set; }

    /// <summary>
    /// 查询分组
    /// </summary>
    public string SQueryGroup { get; set; }

    /// <summary>
    /// 查询排序
    /// </summary>
    public string SQueryOrder { get; set; }

    public string SMemo { get; set; }
}
