using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class VAttendance
{
    public int Autoid { get; set; }

    public int? EmployeeId { get; set; }

    public int? PeriodNo { get; set; }

    public DateTime? SDate { get; set; }

    public string BAttTimeStr { get; set; }

    public string EAttTimeStr { get; set; }

    public int? BOffset { get; set; }

    public int? EOffset { get; set; }

    public decimal? BOffsetFee { get; set; }

    public decimal? EOffsetFee { get; set; }
}
