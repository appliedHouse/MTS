using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormBoxTransactionItem
{
    public int AssetFormBoxTransactionItemId { get; set; }

    public int AssetFormBoxTransactionId { get; set; }

    public int AssetId { get; set; }

    public int? AssetTransactionLogId { get; set; }

    public decimal? Weight { get; set; }

    public int? Quantity { get; set; }

    public decimal? ExteraCostUnit { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual AssetFormBoxTransaction AssetFormBoxTransaction { get; set; } = null!;

    public virtual AssetTransactionLog? AssetTransactionLog { get; set; }
}
