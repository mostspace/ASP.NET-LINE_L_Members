using System;
using System.Collections.Generic;

namespace nxLINEadminAPI.Entity;

public class Checkin
{
    public int CheckinId { get; set; }

    public string CheckinUserid { get; set; } = null!;

    public string? CheckinLineid { get; set; }

    public int CheckinCheckpointId { get; set; }

    public DateTime CheckinCreated { get; set; }

    public virtual Checkpoint CheckinCheckpoint { get; set; } = null!;
}
