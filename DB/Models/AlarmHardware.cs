using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AlarmHardware
{
    public Guid AlarmId { get; set; }

    public int HardwareId { get; set; }

    public bool ForEntity { get; set; }

    public virtual Alarm Alarm { get; set; } = null!;

    public virtual Hardware Hardware { get; set; } = null!;
}
