using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class TempProcessRegeofencingItem
{
    public int ProcessId { get; set; }

    public int TempAssetProcessId { get; set; }

    public int AssetId { get; set; }

    public int NewLocationId { get; set; }

    public DateTime TransferDate { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual Location NewLocation { get; set; } = null!;

    public virtual TempProcess TempAssetProcess { get; set; } = null!;
}
