using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class VAttendanceEvent
{
    public int AutoId { get; set; }

    public string EventDescription { get; set; }

    public decimal? FeeCar { get; set; }

    public decimal? FeeMeals { get; set; }

    public decimal? FeeOther { get; set; }

    public bool? IsCar { get; set; }

    public string Other { get; set; }

    public string Memo { get; set; }

    public string CheckMan { get; set; }

    public string Manager { get; set; }

    public int RecordId { get; set; }

    public bool IsBeginTime { get; set; }

    public int? PeriodNo { get; set; }

    public string BAttTimeStr { get; set; }

    public string EAttTimeStr { get; set; }

    public int? BOffset { get; set; }

    public int? EOffset { get; set; }

    public DateTime? SDate { get; set; }

    public int? EmployeeId { get; set; }

    public string BTime { get; set; }

    public string ETime { get; set; }
}
