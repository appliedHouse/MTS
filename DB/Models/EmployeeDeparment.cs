using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class EmployeeDeparment
{
    public int DepartmentId { get; set; }

    public string? DepartmentCode { get; set; }

    public string DepartmentName { get; set; } = null!;

    public int? LocationId { get; set; }

    public Guid TransactionId { get; set; }

    public string? IntgId { get; set; }

    public virtual ICollection<AssetForm> AssetFormNewEmployeeDepartments { get; set; } = new List<AssetForm>();

    public virtual ICollection<AssetForm> AssetFormOldEmployeeDepartments { get; set; } = new List<AssetForm>();

    public virtual ICollection<EmployeeSign> EmployeeSigns { get; set; } = new List<EmployeeSign>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Location? Location { get; set; }

    public virtual SystemTransaction Transaction { get; set; } = null!;
}
