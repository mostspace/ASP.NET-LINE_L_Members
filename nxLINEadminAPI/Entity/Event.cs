using System;
using System.Collections.Generic;

namespace nxLINEadminAPI.Entity;

public class Event
{
    public int EventId { get; set; }

    public byte EventStatus { get; set; }

    public string EventName { get; set; } = null!;

    public DateTime EventStartdate { get; set; }

    public DateTime EventEnddate { get; set; }

    public string? EventImageurl { get; set; }

    public string? EventStampurl { get; set; }

    public string? EventDescription { get; set; }

    public string? EventUrl { get; set; }

    public string? EventLiffid { get; set; }

    public DateTime? EventCreated { get; set; }

    public DateTime? EventUpdated { get; set; }

    public DateTime? EventDeleted { get; set; }

    public virtual ICollection<Checkpoint> Checkpoints { get; set; } = new List<Checkpoint>();
}
