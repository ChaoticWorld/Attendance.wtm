using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class VPetitionList
{
    public int Id { get; set; }

    public string CCode { get; set; }

    public string CCreateMan { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string CCusManager { get; set; }

    public string CModifyMan { get; set; }

    public DateTime? DModifyDate { get; set; }

    public string CCusCode { get; set; }

    public string CCusName { get; set; }

    public string CCusPerson { get; set; }

    public DateTime? DExpDate { get; set; }

    public DateTime? DEffDate { get; set; }

    public string MainMemo { get; set; }

    public int? QcRcid { get; set; }

    public string QcOrderCode { get; set; }

    public string CInvCode { get; set; }

    public string CInvName { get; set; }

    public string CInvStd { get; set; }

    public decimal? IQuentity { get; set; }

    public decimal? IPrice { get; set; }

    public decimal? ISum { get; set; }

    public string DetailsMemo { get; set; }

    public bool? BDaiShouKuan { get; set; }

    public DateTime? DSaleSumStartDate { get; set; }

    public DateTime? DSaleSumFinishDate { get; set; }

    public string QcSubmitMan { get; set; }

    public DateTime? QcSubmitDate { get; set; }

    public string QcReplyMan { get; set; }

    public DateTime? QcReplyDate { get; set; }

    public string QcReplyContent { get; set; }

    public bool? QcReplyPass { get; set; }

    public int? QcNextId { get; set; }

    public string SubmitMan { get; set; }

    public string ReplyMan { get; set; }
}
