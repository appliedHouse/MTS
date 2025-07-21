using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class ServiceFunction
{
    public int FunctionId { get; set; }

    public string FuncationName { get; set; } = null!;

    public string? FuncationIcon { get; set; }

    public virtual ICollection<GroupPrivilege> GroupPrivileges { get; set; } = new List<GroupPrivilege>();
}
