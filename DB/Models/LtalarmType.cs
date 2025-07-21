using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtalarmType
{
    public int AlarmTypeId { get; set; }

    public string AlarmTypeKey { get; set; } = null!;

    public int AlramTypePeriority { get; set; }

    public bool Enabled { get; set; }

    public virtual ICollection<Alarm> Alarms { get; set; } = new List<Alarm>();

    public virtual ICollection<UserAlarm> UserAlarms { get; set; } = new List<UserAlarm>();
}
