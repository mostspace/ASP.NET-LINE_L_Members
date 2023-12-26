using System;
using System.Collections.Generic;

namespace nxLINEadminAPI.Models;

public partial class Division
{
    public int DivisionId { get; set; }

    public string DivisionName { get; set; } = null!;

    public bool DivisionVisibility { get; set; }

    public int DivisionOrdinal { get; set; }

    public string? DivisionBumonKind { get; set; }

    public string? DivisionFbCompanycode { get; set; }

    public string? DivisionFbBankcode { get; set; }

    public string? DivisionFbBankkana { get; set; }

    public string? DivisionFbBranchcode { get; set; }

    public string? DivisionFbBranchkana { get; set; }

    public string? DivisionFbAccounttype { get; set; }

    public string? DivisionFbAccountnum { get; set; }

    public string? DivisionFbAccountkana { get; set; }

    public DateTime? DivisionCreatedat { get; set; }

    public DateTime? DivisionUpdatedat { get; set; }

    public DateTime? DivisionDeletedat { get; set; }
}
