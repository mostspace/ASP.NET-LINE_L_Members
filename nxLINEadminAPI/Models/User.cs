using System;
using System.Collections.Generic;

namespace nxLINEadminAPI.Models;

public partial class User
{
    public int UserId { get; set; }

    public int Status { get; set; }

    public int ShopId { get; set; }

    public string? UserDivisions { get; set; }

    public int? UserDivisionId { get; set; }

    public int? UserStoreId { get; set; }

    public DateTime WorkEndDate { get; set; }

    public string? UserCode { get; set; }

    public string UserLoginid { get; set; } = null!;

    public string UserPwd { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string UserDisplayName { get; set; } = null!;

    public string? UserEmail { get; set; }

    public string UserLv { get; set; } = null!;

    public string? UserToken { get; set; }

    public DateTime? UserLastlogindatetime { get; set; }

    public string? UserDefaultSeisanKind { get; set; }

    public DateTime UpdateDatetime { get; set; }

    public int? UserLineaccountId { get; set; }

    public string? UserLineaccountRole { get; set; }

    public DateTime UserCreated { get; set; }

    public DateTime? UserUpdated { get; set; }

    public DateTime? UserDeleted { get; set; }
}
