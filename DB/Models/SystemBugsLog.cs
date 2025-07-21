using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class SystemBugsLog
{
    public int BugLogId { get; set; }

    public DateTime? BugDate { get; set; }

    public string? Message { get; set; }

    public string? Source { get; set; }

    public string? StackTrace { get; set; }

    public string? MethodName { get; set; }

    public string? AppName { get; set; }

    public bool? Recived { get; set; }

    public bool Solved { get; set; }

    public int? UserId { get; set; }

    public virtual UserAccount? User { get; set; }
}
