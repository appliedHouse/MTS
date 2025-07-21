using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class UserTaskRole
{
    public int UserTaskRoleId { get; set; }

    public int TaskRoleId { get; set; }

    public int UserId { get; set; }

    public Guid AddTransactionId { get; set; }

    public virtual TaskRole TaskRole { get; set; } = null!;

    public virtual UserAccount User { get; set; } = null!;
}
