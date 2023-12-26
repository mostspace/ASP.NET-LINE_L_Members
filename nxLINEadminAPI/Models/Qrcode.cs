using System;
using System.Collections.Generic;

namespace nxLINEadminAPI.Models;

public partial class Qrcode
{
    public int QrcodeId { get; set; }

    public string QrcodeGuid { get; set; } = null!;

    public short QrcodeType { get; set; }

    public string? QrcodeName { get; set; }

    public string QrcodeDescription { get; set; } = null!;

    public int QrcodePoint { get; set; }

    public DateTime QrcodeExpiry { get; set; }

    public DateTime? QrcodeCreated { get; set; }

    public DateTime? QrcodeUpdated { get; set; }

    public DateTime? QrcodeDeleted { get; set; }
}
