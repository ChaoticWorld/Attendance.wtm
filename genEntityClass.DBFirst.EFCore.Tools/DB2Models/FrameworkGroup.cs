using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    public partial class FrameworkGroup
    {
        public FrameworkGroup()
        {
            InverseParent = new HashSet<FrameworkGroup>();
        }

        public Guid Id { get; set; }
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public string GroupRemark { get; set; }
        public string Manager { get; set; }
        public string TenantCode { get; set; }
        public Guid? ParentId { get; set; }

        public virtual FrameworkGroup Parent { get; set; }
        public virtual ICollection<FrameworkGroup> InverseParent { get; set; }
    }
}
