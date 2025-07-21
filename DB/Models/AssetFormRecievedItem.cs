using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormRecievedItem
{
    public int AssetFormRecievedItemId { get; set; }

    public int AssetFormId { get; set; }

    public int AssetId { get; set; }

    public int? AssetTransactionId { get; set; }

    public int? ProcessId { get; set; }

    public int FromLocationId { get; set; }

    public int ToLocationId { get; set; }

    public int ExportFormId { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual AssetForm AssetForm { get; set; } = null!;

    public virtual AssetTransactionLog? AssetTransaction { get; set; }

    public virtual AssetForm ExportForm { get; set; } = null!;

    public virtual Location FromLocation { get; set; } = null!;

    public virtual Location ToLocation { get; set; } = null!;
}
