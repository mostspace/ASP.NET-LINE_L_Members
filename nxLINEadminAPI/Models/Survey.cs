using System;
using System.Collections.Generic;

namespace nxLINEadminAPI.Models;

public partial class Survey
{
    public int SurveyId { get; set; }

    public string SurveyCode { get; set; } = null!;

    public string SurveyName { get; set; } = null!;

    public string? SurveyTitle { get; set; }

    public string? SurveyText { get; set; }

    public string SurveyImageurl { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int SurveyType { get; set; }

    public int? Subtotal { get; set; }

    public string? Ranks { get; set; }

    public short LimitCount { get; set; }

    public short LimitDays { get; set; }

    public string? SurveyGroup { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Updatedat { get; set; }

    public DateTime? Deletedat { get; set; }

    public string? Probability { get; set; }

    public string? Upperlimit { get; set; }

    public string? Resultimageurl { get; set; }

    public string? SurveyLinktext { get; set; }
}
