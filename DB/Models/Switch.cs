using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Switch
{
    public int SwitchId { get; set; }

    public string SwitchIp { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int LocationId { get; set; }

    public string? TelNetPassword { get; set; }

    public string? Notes { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual ICollection<Hardware> Hardwares { get; set; } = new List<Hardware>();

    public virtual Location Location { get; set; } = null!;

    public virtual SystemTransaction? UpdateTransaction { get; set; }
}
