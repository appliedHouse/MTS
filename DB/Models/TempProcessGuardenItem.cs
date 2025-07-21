using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class TempProcessGuardenItem
{
    public int ProcessId { get; set; }

    public int TempProcessId { get; set; }

    public int AssetId { get; set; }

    public int NewGuardenId { get; set; }

    public int? NewAssetSateId { get; set; }

    public DateTime ProcessDate { get; set; }

    public bool IsTransfare { get; set; }

    public bool IsPendingState { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual ICollection<AssetFormGurdianshipItem> AssetFormGurdianshipItems { get; set; } = new List<AssetFormGurdianshipItem>();

    public virtual LtassetState? NewAssetSate { get; set; }

    public virtual Employee NewGuarden { get; set; } = null!;

    public virtual TempProcess TempProcess { get; set; } = null!;
}
