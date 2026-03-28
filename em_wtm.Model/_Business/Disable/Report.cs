using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class Report
{
    public int ReportId { get; set; }

    public string Description { get; set; }

    public string Name { get; set; }

    public string Title { get; set; }

    public string QueryBase { get; set; }

    public int? ClsId { get; set; }

    public int? ModuleId { get; set; }

    public int? ErpVisitFieldId { get; set; }

    /// <summary>
    /// 是否带参数的存储过程
    /// </summary>
    public bool? IsProcessWithParams { get; set; }

    /// <summary>
    /// 客户权限控制
    /// </summary>
    public bool? CustPermission { get; set; }
}
