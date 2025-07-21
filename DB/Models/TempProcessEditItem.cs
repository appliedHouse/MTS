using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class TempProcessEditItem
{
    public int ProcessId { get; set; }

    public int TempProcessId { get; set; }

    public int AssetId { get; set; }

    public DateTime ProcessDate { get; set; }

    public bool IsTransfer { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual ICollection<TempAssetEditTag> TempAssetEditTags { get; set; } = new List<TempAssetEditTag>();

    public virtual TempProcess TempProcess { get; set; } = null!;
}
