using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class WarehousReturnFormItem
{
    public int WarehouseFormItemId { get; set; }

    public int FormId { get; set; }

    public int AssetId { get; set; }

    public int? AssetTransactionId { get; set; }

    public int? ProcessId { get; set; }

    public int ReturnedFromLocationId { get; set; }

    public int OldAssetStateId { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual AssetTransactionLog? AssetTransaction { get; set; }

    public virtual WarehouseForm Form { get; set; } = null!;

    public virtual LtassetState OldAssetState { get; set; } = null!;

    public virtual TempProcessReturnItem? Process { get; set; }

    public virtual Location ReturnedFromLocation { get; set; } = null!;
}
