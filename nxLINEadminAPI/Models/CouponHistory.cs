using System;
using System.Collections.Generic;

namespace nxLINEadminAPI.Models;

public partial class CouponHistory
{
    public string CouponHistoryId { get; set; } = null!;

    public int CouponId { get; set; }

    public string? CouponGroup { get; set; }

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
