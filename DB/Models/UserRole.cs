using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class UserRole
{
    public int UserRoleId { get; set; }

    public int UserId { get; set; }

    public int GroupId { get; set; }

    public Guid AddTransactionId { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual UserGroup Group { get; set; } = null!;

    public virtual UserAccount User { get; set; } = null!;
}
