using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class SystemCore
{
    public int CoreId { get; set; }

    public string CoreIp { get; set; } = null!;

    public int CorePort { get; set; }

    public bool IsConnected { get; set; }

    public int? ZoneId { get; set; }

    public DateTime RegisterDate { get; set; }

    public bool IsActive { get; set; }

    public int? LicenseId { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual License? License { get; set; }

    public virtual SystemTransaction? UpdateTransaction { get; set; }

    public virtual Zone? Zone { get; set; }
}
