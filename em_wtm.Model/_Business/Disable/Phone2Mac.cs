using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class Phone2Mac
{
    /// <summary>
    /// 序号
    /// </summary>
    public int Autoid { get; set; }

    /// <summary>
    /// 分机号
    /// </summary>
    public int ExtId { get; set; }

    /// <summary>
    /// mac地址
    /// </summary>
    public string MacAddress { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// 是否本地
    /// </summary>
    public bool IsLocal { get; set; }

    /// <summary>
    /// ip地址
    /// </summary>
    public string Ipaddress { get; set; }

    /// <summary>
    /// 是否远程分机
    /// </summary>
    public bool? IsRemoteExt { get; set; }
}
