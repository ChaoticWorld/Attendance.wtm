using System;
using System.Collections.Generic;

namespace em_wtm.Model._Business.Disable;

public partial class QcReply
{
    public int AutoId { get; set; }

    /// <summary>
    /// 签呈主ID
    /// </summary>
    public int? QcMainId { get; set; }

    /// <summary>
    /// 提交人
    /// </summary>
    public string QcSubmitMan { get; set; }

    /// <summary>
    /// 提交日期
    /// </summary>
    public DateTime? QcSubmitDate { get; set; }

    /// <summary>
    /// 批复人
    /// </summary>
    public string QcReplyMan { get; set; }

    /// <summary>
    /// 批复日期
    /// </summary>
    public DateTime? QcReplyDate { get; set; }

    /// <summary>
    /// 批复内容
    /// </summary>
    public string QcReplyContent { get; set; }

    /// <summary>
    /// 签呈是否通过
    /// </summary>
    public bool? QcReplyPass { get; set; }

    /// <summary>
    /// 转交他人批复的AutoID
    /// </summary>
    public int? QcNextId { get; set; }

    public string SubmitMan { get; set; }

    public string ReplyMan { get; set; }
}
