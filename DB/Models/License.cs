using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class License
{
    public int LicenseId { get; set; }

    public string MachineName { get; set; } = null!;

    public string MachineDesc { get; set; } = null!;

    public string Mcode { get; set; } = null!;

    public string? LicKey { get; set; }

    public string? LicenseName { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public DateTime RequestdDate { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public int? ApprovedBy { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    public virtual ICollection<SystemApp> SystemApps { get; set; } = new List<SystemApp>();

    public virtual ICollection<SystemCore> SystemCores { get; set; } = new List<SystemCore>();
}
