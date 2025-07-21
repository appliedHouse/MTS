using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtmaintenanceType
{
    public int MaintenanceTypeId { get; set; }

    public string MaintenanceTypeName { get; set; } = null!;

    public virtual ICollection<AssetMaintenanceForm> AssetMaintenanceForms { get; set; } = new List<AssetMaintenanceForm>();
}
