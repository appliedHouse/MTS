using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Branch
{
    public int BranchId { get; set; }

    public string BranchName { get; set; } = null!;

    public int? LicenseId { get; set; }

    public virtual License? License { get; set; }
}
