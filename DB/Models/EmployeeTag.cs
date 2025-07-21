using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class EmployeeTag
{
    public int EmployeeTagId { get; set; }

    public int EmployeeId { get; set; }

    public string TagId { get; set; } = null!;

    public int? TagTypeId { get; set; }

    public string? Tid { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
