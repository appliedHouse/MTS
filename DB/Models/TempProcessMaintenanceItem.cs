using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class TempProcessMaintenanceItem
{
    public int ProcessId { get; set; }

    public int TempAssetProcessId { get; set; }

    public int AssetId { get; set; }

    public DateTime ProcessDate { get; set; }

    public int MaintenanceLocationId { get; set; }

    public int EmployeeId { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual TempProcess TempAssetProcess { get; set; } = null!;
}
