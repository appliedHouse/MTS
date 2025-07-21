using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Smslog
{
    public int Smsid { get; set; }

    public DateTime SendDate { get; set; }

    public string Message { get; set; } = null!;

    public int UserScheduleId { get; set; }

    public Guid AlarmId { get; set; }

    public string? ServiceResult { get; set; }

    public virtual Alarm Alarm { get; set; } = null!;

    public virtual UserScheduleI UserSchedule { get; set; } = null!;
}
