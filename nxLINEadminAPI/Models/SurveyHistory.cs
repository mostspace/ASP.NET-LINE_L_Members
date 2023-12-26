using System;
using System.Collections.Generic;

namespace nxLINEadminAPI.Models;

public partial class SurveyHistory
{
    public string SurveyHistoryId { get; set; } = null!;

    public int SurveyId { get; set; }

    public string? SurveyGroup { get; set; }

    public int MemberId { get; set; }

    public string? MemberLineid { get; set; }

    public DateTime DeliveryDatetime { get; set; }

    public short UseCount { get; set; }

    public DateTime? LastUseDatetime { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Sendedat { get; set; }

    public string? TransactionHeadId { get; set; }

    public int? Subtotal { get; set; }

    public string? Result { get; set; }
}
