using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class UserGroup
{
    public int UserGroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public string? GroupDescription { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual ICollection<GroupPrivilege> GroupPrivileges { get; set; } = new List<GroupPrivilege>();

    public virtual SystemTransaction? UpdateTransaction { get; set; }

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
