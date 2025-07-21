using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormItemDistribute
{
    public int AssetFormItemId { get; set; }

    public int AssetFormId { get; set; }

    public int AssetId { get; set; }

    public int TransactionAssetId { get; set; }

    public int FromLocationId { get; set; }

    public int NewLocationId { get; set; }

    public int? ProcessId { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual AssetForm AssetForm { get; set; } = null!;

    public virtual Location NewLocation { get; set; } = null!;

    public virtual AssetTransactionLog TransactionAsset { get; set; } = null!;
}
