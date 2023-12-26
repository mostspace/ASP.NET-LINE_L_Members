using System;
using System.Collections.Generic;

namespace nxLINEadminAPI.Models;

public partial class Lineaccount
{
    public int LineaccountId { get; set; }

    public string LineaccountCode { get; set; } = null!;

    public string LineaccountShortcode { get; set; } = null!;

    public string? LineaccountName { get; set; }

    public string LineaccountEmail { get; set; } = null!;

    public bool? Istalk { get; set; }

    public string? Talkmessage { get; set; }

    public bool? Isprofile { get; set; }

    public string? ProfileSetting { get; set; }

    public int? Entrypoint { get; set; }

    public int? Startrank { get; set; }

    public int? Pointexpire { get; set; }

    public string? MemberscardColor { get; set; }

    public string? MemberscardDesignurl { get; set; }

    public bool? MemberscardIsusecamera { get; set; }

    public string? MemberscardLiffid { get; set; }

    public string? LineChannelid { get; set; }

    public string? LineChannelsecret { get; set; }

    public string? LineChannelaccesstoken { get; set; }

    public bool? Issmaregi { get; set; }

    public string? SmaregiContractid { get; set; }

    public string? LineaccountLogourl { get; set; }

    public DateTime? LineaccountCreated { get; set; }

    public DateTime? LineaccountUpdated { get; set; }

    public DateTime? LineaccountDeleted { get; set; }
}
