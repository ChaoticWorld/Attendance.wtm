using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class VReportPermission
{
    public long ReportId { get; set; }

    public string Description { get; set; }

    public string Name { get; set; }

    public string Title { get; set; }

    public string QueryBase { get; set; }

    public long? ClsId { get; set; }

    public long? ModuleId { get; set; }

    public long? UserId { get; set; }
}
