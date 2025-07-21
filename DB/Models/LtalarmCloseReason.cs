using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtalarmCloseReason
{
    public int AlarmCloseReasonId { get; set; }

    public string CloseReasonKey { get; set; } = null!;

    public bool IsUserResponse { get; set; }

    public int CreatorTypeId { get; set; }

    public virtual ICollection<Alarm> Alarms { get; set; } = new List<Alarm>();

    public virtual LtcreatorType CreatorType { get; set; } = null!;
}
