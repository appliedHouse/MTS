using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class UserScheduleIlog
{
    public int UserScheduleId { get; set; }

    public int UserId { get; set; }

    public int DayId { get; set; }

    public TimeOnly FromTime { get; set; }

    public TimeOnly ToTime { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public virtual LtdayName Day { get; set; } = null!;

    public virtual UserAccount User { get; set; } = null!;
}
