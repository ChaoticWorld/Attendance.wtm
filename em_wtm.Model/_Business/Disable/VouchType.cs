using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class VouchType
{
    public int Id { get; set; }

    public string VouchClass { get; set; }

    public string VouchType1 { get; set; }

    public string VouchName { get; set; }

    public int? VouchOrder { get; set; }

    public string Key { get; set; }
}
