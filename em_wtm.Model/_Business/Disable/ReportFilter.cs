using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class ReportFilter
{
    public int FilterId { get; set; }

    public int? ReportId { get; set; }

    public int? UserId { get; set; }

    public int? FilterIndex { get; set; }

    public int? FieldId { get; set; }

    public string Value { get; set; }

    public string FieldName { get; set; }

    public string LogicOperator { get; set; }

    public string ComparisonOperator { get; set; }
}
