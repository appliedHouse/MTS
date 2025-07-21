using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormEndLifeItem
{
    public int AssetFormEndLifeItemId { get; set; }

    public int AssetFormEndLifeId { get; set; }

    public int AssetId { get; set; }

    public int? AssetTransactionId { get; set; }

    public int? ProcessId { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual AssetFormEndLife AssetFormEndLife { get; set; } = null!;

    public virtual AssetTransactionLog? AssetTransaction { get; set; }

    public virtual TempProcess? Process { get; set; }
}
