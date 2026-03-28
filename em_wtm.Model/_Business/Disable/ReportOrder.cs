using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class ReportOrder
{
    public int OrderId { get; set; }

    public int? ReportId { get; set; }

    public int? UserId { get; set; }

    public int? FieldId { get; set; }

    public int? OrderIndex { get; set; }

    public string OrderString { get; set; }

    /// <summary>
    /// 1:升序；0:降序
    /// </summary>
    public bool? IsAsc { get; set; }

    public string FieldName { get; set; }
}
