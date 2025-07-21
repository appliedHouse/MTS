using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class EmployeeSign
{
    public int SignId { get; set; }

    public string SignTitle { get; set; } = null!;

    public string? SignStamp { get; set; }

    public int EmployeeId { get; set; }

    public int EmployeeDepId { get; set; }

    public bool IsActive { get; set; }

    public Guid? AddTransactionId { get; set; }

    public virtual SystemTransaction? AddTransaction { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual EmployeeDeparment EmployeeDep { get; set; } = null!;

    public virtual ICollection<FormSign> FormSigns { get; set; } = new List<FormSign>();
}
