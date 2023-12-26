using System;
using System.Collections.Generic;

namespace nxLINEadminAPI.Models;

public partial class Member
{
    public int MemberId { get; set; }

    public int? MemberPosId { get; set; }

    public string? MemberCode { get; set; }

    public int MemberShopId { get; set; }

    public string MemberLastname { get; set; } = null!;

    public string MemberFirstname { get; set; } = null!;

    public string MemberLastnameKana { get; set; } = null!;

    public string MemberFirstnameKana { get; set; } = null!;

    public string? MemberZipcode { get; set; }

    public string? MemberPref { get; set; }

    public string? MemberCity { get; set; }

    public string? MemberAddress { get; set; }

    public string? MemberTel { get; set; }

    public string? MemberFax { get; set; }

    public string? MemberMobile { get; set; }

    public string? MemberEmail { get; set; }

    public byte? MemberGender { get; set; }

    public DateTime? MemberBirthday { get; set; }

    public int? MemberHoldPoint { get; set; }

    public DateTime? MemberPointLimitDate { get; set; }

    public DateTime? MemberLastPointgetDate { get; set; }

    public short? MemberLastPointgetPoint { get; set; }

    public DateTime? MemberLastVisitDate { get; set; }

    public DateTime? MemberJoinDate { get; set; }

    public DateTime? MemberDropDate { get; set; }

    public byte? MemberAllowEmail { get; set; }

    public string? MemberRank { get; set; }

    public string? MemberNote { get; set; }

    public byte MemberStatus { get; set; }

    public int MemberOrdinal { get; set; }

    public bool MemberVisibility { get; set; }

    public string? MemberTag { get; set; }

    public string? MemberNonce { get; set; }

    public string? MemberLineid { get; set; }

    public string? MemberStripeId { get; set; }

    public string? MemberFamily1Name { get; set; }

    public DateTime? MemberFamily1Birthday { get; set; }

    public byte? MemberFamily1Gender { get; set; }

    public string? MemberFamily1Relative { get; set; }

    public string? MemberFamily2Name { get; set; }

    public DateTime? MemberFamily2Birthday { get; set; }

    public byte? MemberFamily2Gender { get; set; }

    public string? MemberFamily2Relative { get; set; }

    public string? MemberFamily3Name { get; set; }

    public DateTime? MemberFamily3Birthday { get; set; }

    public byte? MemberFamily3Gender { get; set; }

    public string? MemberFamily3Relative { get; set; }

    public string? MemberPasswordHash { get; set; }

    public string? MemberPasswordSalt { get; set; }

    public string? MemberEmailVerifyToken { get; set; }

    public DateTime? MemberEmailVerifyExpiredAt { get; set; }

    public string? MemberPasswordResetToken { get; set; }

    public DateTime? MemberPasswordResetVerifyExpiredAt { get; set; }

    public bool MemberIsPasswordResetVerified { get; set; }

    public string? MemberPendingEmail { get; set; }

    public string? MemberPendingEmailVerifyToken { get; set; }

    public bool MemberIsSignupVerified { get; set; }

    public string? MemberSignupVerifyToken { get; set; }

    public string? MemberSearchtext { get; set; }

    public DateTime MemberCreateat { get; set; }

    public DateTime? MemberUpdateat { get; set; }

    public DateTime? MemberDeleteat { get; set; }

    public string? MemberProfileicon { get; set; }
}
