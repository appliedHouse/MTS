using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormTransferItem
{
    public int AssetTransferFormItemId { get; set; }

    public int AssetTransferFormId { get; set; }

    public int AssetId { get; set; }

    public int? AssetTransactionId { get; set; }

    public int? ProcessId { get; set; }

    public int FromLocationId { get; set; }

    public int ToLocationId { get; set; }

    public int OldAssetStateId { get; set; }

    public int NewAssetStateId { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual AssetTransactionLog? AssetTransaction { get; set; }

    public virtual AssetForm AssetTransferForm { get; set; } = null!;

    public virtual Location FromLocation { get; set; } = null!;

    public virtual LtassetState NewAssetState { get; set; } = null!;

    public virtual LtassetState OldAssetState { get; set; } = null!;

    public virtual TempProcessTransferItem? Process { get; set; }

    public virtual Location ToLocation { get; set; } = null!;
}
