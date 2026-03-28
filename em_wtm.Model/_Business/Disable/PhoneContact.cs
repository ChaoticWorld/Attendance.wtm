using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class PhoneContact
{
    /// <summary>
    /// 联系人ID
    /// </summary>
    public int ContactId { get; set; }

    /// <summary>
    /// 姓名
    /// </summary>
    public string ContactName { get; set; }

    /// <summary>
    /// 性别
    /// </summary>
    public bool? ContactGender { get; set; }

    /// <summary>
    /// 关联企业
    /// </summary>
    public string ContactRefEnterprises { get; set; }

    /// <summary>
    /// 企业部门
    /// </summary>
    public string ContactEnterpriseDepartment { get; set; }

    /// <summary>
    /// 企业职位
    /// </summary>
    public string ContactEnterprisePosition { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string ContactMemo { get; set; }
}
