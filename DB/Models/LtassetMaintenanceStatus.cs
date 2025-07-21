using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtassetMaintenanceStatus
{
    public int AssetMaintenanceStatusId { get; set; }

    public string AssetMaintenanceStatusName { get; set; } = null!;

    public virtual ICollection<AssetFormMaintenanceItem> AssetFormMaintenanceItems { get; set; } = new List<AssetFormMaintenanceItem>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogs { get; set; } = new List<AssetTransactionLog>();

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();
}
