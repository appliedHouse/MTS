using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormBoxTransaction
{
    public int AssetFormBoxTransactionId { get; set; }

    public string CustomerName { get; set; } = null!;

    public int? Quantity { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Cost { get; set; }

    public int BoxTransactionTypeId { get; set; }

    public virtual ICollection<AssetFormBoxTransactionItem> AssetFormBoxTransactionItems { get; set; } = new List<AssetFormBoxTransactionItem>();

    public virtual AssetForm AssetFormBoxTransactionNavigation { get; set; } = null!;

    public virtual LtboxTransactionType BoxTransactionType { get; set; } = null!;
}
