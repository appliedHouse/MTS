using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class UserTaskAction
{
    public int UserTaskActionId { get; set; }

    public int UserTaskId { get; set; }

    public int UserId { get; set; }

    public int Action { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime Date { get; set; }

    public virtual UserAccount User { get; set; } = null!;

    public virtual UserTask UserTask { get; set; } = null!;

    public virtual ICollection<UserTaskActionLog> UserTaskActionLogs { get; set; } = new List<UserTaskActionLog>();
}
