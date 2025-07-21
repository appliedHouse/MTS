using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtalarmNotificationType
{
    public int NotificationTypeId { get; set; }

    public string NotificationTypeKey { get; set; } = null!;

    public virtual ICollection<UserAlarm> UserAlarms { get; set; } = new List<UserAlarm>();
}
