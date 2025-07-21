using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtalarmStatus
{
    public int AlarmStatusId { get; set; }

    public string? AlarmStatusKey { get; set; }

    public virtual ICollection<Alarm> Alarms { get; set; } = new List<Alarm>();
}
