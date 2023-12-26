using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace nxLINEadminAPI.Entity;

public class Checkpoint
{
    public int CheckpointId { get; set; }

    public string CheckpointName { get; set; } = null!;

    public int CheckpointEventId { get; set; }

    public string? CheckpointImageurl { get; set; }

    public string? CheckpointDescription { get; set; }

    public string? CheckpointUrl { get; set; }

    public DateTime? CheckpointCreated { get; set; }

    public DateTime? CheckpointUpdated { get; set; }

    public DateTime? CheckpointDeleted { get; set; }

    public virtual ICollection<Checkin> Checkins { get; set; } = new List<Checkin>();

    [JsonIgnore]
    public virtual Event CheckpointEvent { get; set; } = null!;
}
