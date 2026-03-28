using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class ReportField
{
    public int FieldId { get; set; }

    public int? ReportId { get; set; }

    public int? FieldIndex { get; set; }

    public string FieldTitle { get; set; }

    public string FieldName { get; set; }

    public bool? IsDisplay { get; set; }

    public bool? IsErpEmployeeVisit { get; set; }

    public string FieldNameCompute { get; set; }

    public bool? IsParam { get; set; }
}
