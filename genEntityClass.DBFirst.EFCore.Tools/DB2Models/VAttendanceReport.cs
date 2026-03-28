using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    public partial class VAttendanceReport
    {
        public int RecordId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime SDate { get; set; }
        public string Description { get; set; }
        public TimeSpan? BAttTime { get; set; }
        public int? BOffset { get; set; }
        public TimeSpan? EAttTime { get; set; }
        public int? EOffset { get; set; }
        public decimal? BOffsetFee { get; set; }
        public decimal? EOffsetFee { get; set; }
        public string Event { get; set; }
        public decimal? Fee { get; set; }
    }
}
