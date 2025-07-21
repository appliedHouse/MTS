using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormMaintenanceItem
{
    public int AssetFormMaintainanceItemId { get; set; }

    public int AssetMaintenanceFormId { get; set; }

    public DateTime MaintananceDate { get; set; }

    public DateTime ExpectedReturnDate { get; set; }

    public bool IsReturned { get; set; }

    public int AssetId { get; set; }

    public int NewAssetLocationId { get; set; }

    public int? NewAssetMaintenanceStatusId { get; set; }

    public int? AssetTransactionLogId { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual AssetMaintenanceForm AssetMaintenanceForm { get; set; } = null!;

    public virtual AssetTransactionLog? AssetTransactionLog { get; set; }

    public virtual Location NewAssetLocation { get; set; } = null!;

    public virtual LtassetMaintenanceStatus? NewAssetMaintenanceStatus { get; set; }
}
