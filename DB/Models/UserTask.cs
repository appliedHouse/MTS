using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class UserTask
{
    public int UserTaskId { get; set; }

    public int UserTaskTypeId { get; set; }

    public string UserTaskTitle { get; set; } = null!;

    public int TaskRoleId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public int State { get; set; }

    public string? Date { get; set; }

    public virtual TaskRole TaskRole { get; set; } = null!;

    public virtual ICollection<UserTaskActionLog> UserTaskActionLogs { get; set; } = new List<UserTaskActionLog>();

    public virtual ICollection<UserTaskAction> UserTaskActions { get; set; } = new List<UserTaskAction>();
}
