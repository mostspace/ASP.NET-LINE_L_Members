using System;
using System.Collections.Generic;

namespace nxLINEadminAPI.Models;

public partial class Coupon
{
    public int CouponId { get; set; }

    public string CouponCode { get; set; } = null!;

    public string CouponName { get; set; } = null!;

    public string? CouponTitle { get; set; }

    public string? CouponText { get; set; }

    public string CouponImageurl { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? CouponType { get; set; }

    public int? Subtotal { get; set; }

    public string? Ranks { get; set; }

    public short LimitCount { get; set; }

    public short LimitDays { get; set; }

    public string? CouponGroup { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Updatedat { get; set; }

    public DateTime? Deletedat { get; set; }

    public string? Probability { get; set; }

    public string? Upperlimit { get; set; }

    public string? Resultimageurl { get; set; }

    public string? Resultmusicurl { get; set; }

    public string? CouponLinktext { get; set; }
}
