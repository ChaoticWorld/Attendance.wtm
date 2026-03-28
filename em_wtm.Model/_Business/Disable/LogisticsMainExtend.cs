using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

/// <summary>
/// 物流企业发货信息
/// </summary>
public partial class LogisticsMainExtend
{
    /// <summary>
    /// 物流主表id
    /// </summary>
    public int Lid { get; set; }

    /// <summary>
    /// 物流企业简称
    /// </summary>
    public string LogisticsEnterpriseAbbName { get; set; }

    /// <summary>
    /// 物流企业id
    /// </summary>
    public string LogisticsEnterpriseId { get; set; }

    /// <summary>
    /// 物流车牌
    /// </summary>
    public string LogisticsEnterpriseTruckNumber { get; set; }

    /// <summary>
    /// 物流随车电话
    /// </summary>
    public string LogisticsEnterpriseTruckPhone { get; set; }
}
