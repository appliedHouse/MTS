using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormGurdianshipItem
{
    public int GurdianshipFormItemId { get; set; }

    public int GurdianshipFormId { get; set; }

    public int AssetId { get; set; }

    public int? ProcessId { get; set; }

    public int? AssetTransactionId { get; set; }

    public int OldAssetStateId { get; set; }

    public int NewStateStateId { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual AssetTransactionLog? AssetTransaction { get; set; }

    public virtual AssetForm GurdianshipForm { get; set; } = null!;

    public virtual LtassetState NewStateState { get; set; } = null!;

    public virtual LtassetState OldAssetState { get; set; } = null!;

    public virtual TempProcessGuardenItem? Process { get; set; }
}
