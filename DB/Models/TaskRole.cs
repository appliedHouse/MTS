using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class TaskRole
{
    public int TaskRoleId { get; set; }

    public string TaskRoleName { get; set; } = null!;

    public bool IsRequiredAllUser { get; set; }

    public Guid? AddTransactionId { get; set; }

    public virtual ICollection<TaskRoleProcess> TaskRoleProcessNextTaskRoles { get; set; } = new List<TaskRoleProcess>();

    public virtual ICollection<TaskRoleProcess> TaskRoleProcessTaskRoles { get; set; } = new List<TaskRoleProcess>();

    public virtual ICollection<UserTaskRole> UserTaskRoles { get; set; } = new List<UserTaskRole>();

    public virtual ICollection<UserTask> UserTasks { get; set; } = new List<UserTask>();
}
