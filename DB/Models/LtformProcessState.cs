using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtformProcessState
{
    public int FormProcessStateId { get; set; }

    public string FormProcessStateKey { get; set; } = null!;

    public virtual ICollection<AssetFormLog> AssetFormLogs { get; set; } = new List<AssetFormLog>();

    public virtual ICollection<AssetForm> AssetForms { get; set; } = new List<AssetForm>();

    public virtual ICollection<ProcessedAssetForm> ProcessedAssetForms { get; set; } = new List<ProcessedAssetForm>();
}
