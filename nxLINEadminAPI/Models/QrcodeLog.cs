using System;
using System.Collections.Generic;

namespace nxLINEadminAPI.Models;

public partial class QrcodeLog
{
    public int QrcodeLogId { get; set; }

    public string QrcodeLogQrcodeId { get; set; } = null!;

    public string QrcodeLogType { get; set; } = null!;

    public int? QrcodeLogMemberId { get; set; }

    public string? QrcodeLogResult { get; set; }

    public string? QrcodeLogMessage { get; set; }

    public DateTime? QrcodeLogCreated { get; set; }
}
