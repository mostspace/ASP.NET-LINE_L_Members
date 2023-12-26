using System;
using System.Collections.Generic;

namespace nxLINEadminAPI.Models;

public partial class Message
{
    public int MessageId { get; set; }

    public int MessageMemberid { get; set; }

    public string MessageLineid { get; set; } = null!;

    public string MessageSendtype { get; set; } = null!;

    public bool MessageIspushnow { get; set; }

    public DateTime MessagePushdatetime { get; set; }

    public string MessageJson { get; set; } = null!;

    public DateTime MessageCreated { get; set; }

    public DateTime? MessageUpdated { get; set; }

    public DateTime? MessageDeleted { get; set; }
}
