using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class ModifySaleDispatchCustomer
{
    public int ILogId { get; set; }

    public DateTime DLogDate { get; set; }

    public int? IUserId { get; set; }

    public string CWorkStation { get; set; }

    public string CIp { get; set; }

    public string CBeforeValue { get; set; }

    public string CModule { get; set; }

    public string CFunction { get; set; }

    public string CParams { get; set; }

    public string CClass { get; set; }

    public string CReturn { get; set; }

    public string CException { get; set; }

    public string CUserName { get; set; }
}
