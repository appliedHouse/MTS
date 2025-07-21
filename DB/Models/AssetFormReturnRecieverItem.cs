using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormReturnRecieverItem
{
    public int AssetFormReturnRecieverItemId { get; set; }

    public int AssetFormId { get; set; }

    public int AssetId { get; set; }

    public int? AssetTransactionId { get; set; }

    public int? ProcessId { get; set; }

    public int AssetFormTransfareId { get; set; }

    public string Reason { get; set; } = null!;

    public virtual Asset Asset { get; set; } = null!;

    public virtual AssetForm AssetForm { get; set; } = null!;

    public virtual AssetForm AssetFormTransfare { get; set; } = null!;

    public virtual AssetTransactionLog? AssetTransaction { get; set; }
}
