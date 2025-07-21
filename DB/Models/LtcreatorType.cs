using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtcreatorType
{
    public int CreatorTypeId { get; set; }

    public string CreatorTypeKey { get; set; } = null!;

    public virtual ICollection<Alarm> Alarms { get; set; } = new List<Alarm>();

    public virtual ICollection<LtalarmCloseReason> LtalarmCloseReasons { get; set; } = new List<LtalarmCloseReason>();
}
