using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    public partial class FrameworkTenant
    {
        public Guid Id { get; set; }
        public string Tcode { get; set; }
        public string Tname { get; set; }
        public string Tdb { get; set; }
        public int? TdbType { get; set; }
        public string DbContext { get; set; }
        public string Tdomain { get; set; }
        public string TenantCode { get; set; }
        public bool EnableSub { get; set; }
        public bool Enabled { get; set; }
        public DateTime? CreateTime { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string UpdateBy { get; set; }
    }
}
