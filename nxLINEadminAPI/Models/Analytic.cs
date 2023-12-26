using System;
using System.Collections.Generic;

namespace nxLINEadminAPI.Models;

public partial class Analytic
{
    public int AnalyticsId { get; set; }

    public string AnalyticsType { get; set; } = null!;

    public int AnalyticsMemberId { get; set; }

    public string? AnalyticsMessage { get; set; }

    public DateTime AnalyticsCreated { get; set; }
}
