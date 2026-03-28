using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class StoreMain
{
    public int MId { get; set; }

    public DateTime? DDate { get; set; }

    public bool? BFlag { get; set; }

    public string CCode { get; set; }

    public string CCusCode { get; set; }

    public string CVenCode { get; set; }

    public string CShipAddress { get; set; }

    public string CMemo { get; set; }

    public string ContactMan { get; set; }

    public string ContactPhone { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string CreateMan { get; set; }

    public string ModifyMan { get; set; }
}
