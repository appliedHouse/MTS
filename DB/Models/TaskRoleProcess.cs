using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class TaskRoleProcess
{
    public int TaskRoleProcessId { get; set; }

    public int ProcessTypeId { get; set; }

    public int TaskRoleId { get; set; }

    public int? NextTaskRoleId { get; set; }

    public Guid AddTransactionId { get; set; }

    public virtual TaskRole? NextTaskRole { get; set; }

    public virtual TaskRole TaskRole { get; set; } = null!;
}
