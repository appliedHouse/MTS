using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class UserTaskActionLog
{
    public int UserTaskActionLogId { get; set; }

    public int UserTaskActionId { get; set; }

    public int UserTaskId { get; set; }

    public int Action { get; set; }

    public string? Notes { get; set; }

    public DateTime Date { get; set; }

    public virtual UserTask UserTask { get; set; } = null!;

    public virtual UserTaskAction UserTaskAction { get; set; } = null!;
}
