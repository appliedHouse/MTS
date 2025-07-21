using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class GroupPrivilege
{
    public int GroupPrivilegeId { get; set; }

    public int ServiceId { get; set; }

    public int GroupId { get; set; }

    public int ServiceFunctionId { get; set; }

    public Guid AddTransactionId { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual UserGroup Group { get; set; } = null!;

    public virtual SystemService Service { get; set; } = null!;

    public virtual ServiceFunction ServiceFunction { get; set; } = null!;
}
