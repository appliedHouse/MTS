using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LthardwareConnectionState
{
    public int ConnectionStateId { get; set; }

    public string? ConnectionStateKey { get; set; }

    public virtual ICollection<HardwareConnectionLog> HardwareConnectionLogs { get; set; } = new List<HardwareConnectionLog>();
}
