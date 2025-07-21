using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class UserAlarm
{
    public int UserAlarmId { get; set; }

    public int UserId { get; set; }

    public int AlarmNotificationTypeId { get; set; }

    public int AlarmTypeId { get; set; }

    public virtual LtalarmNotificationType AlarmNotificationType { get; set; } = null!;

    public virtual LtalarmType AlarmType { get; set; } = null!;

    public virtual UserAccount User { get; set; } = null!;
}
