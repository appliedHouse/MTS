using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class SirenRole
{
    public int SirenRoleId { get; set; }

    public int? SirenId { get; set; }

    public TimeOnly FromTime { get; set; }

    public TimeOnly ToTime { get; set; }

    public int DayId { get; set; }

    public int AlarmPeriod { get; set; }

    public bool IsDefault { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual LtdayName Day { get; set; } = null!;

    public virtual Siren? Siren { get; set; }

    public virtual SystemTransaction? UpdateTransaction { get; set; }
}
