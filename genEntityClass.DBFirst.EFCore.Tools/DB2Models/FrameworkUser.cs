using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    public partial class FrameworkUser
    {
        public Guid Id { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int? Gender { get; set; }
        /// <summary>
        /// 座机
        /// </summary>
        public string HomePhone { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public string ZipCode { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        public string CellPhone { get; set; }
        public DateTime? CreateTime { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string UpdateBy { get; set; }
        public string Itcode { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public bool IsValid { get; set; }
        public Guid? PhotoId { get; set; }
        public string TenantCode { get; set; }

        public virtual FileAttachment Photo { get; set; }
    }
}
