using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class TempProcessTransferItem
{
    public int ProcessId { get; set; }

    public int TempProcessId { get; set; }

    public int AssetId { get; set; }

    public DateTime ProcessDate { get; set; }

    public int NewLocationId { get; set; }

    public int? NewGuardianshipId { get; set; }

    public int? NewAssetTransferStateId { get; set; }

    public bool IsTransfer { get; set; }

    public bool IsPendingState { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual ICollection<AssetFormTransferItem> AssetFormTransferItems { get; set; } = new List<AssetFormTransferItem>();

    public virtual LtassetState? NewAssetTransferState { get; set; }

    public virtual Employee? NewGuardianship { get; set; }

    public virtual Location NewLocation { get; set; } = null!;

    public virtual TempProcess TempProcess { get; set; } = null!;
}
