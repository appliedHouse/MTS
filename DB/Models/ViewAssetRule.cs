using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class ViewAssetRule
{
    public string AssetState { get; set; } = null!;

    public string NewAssetSate { get; set; } = null!;

    public int CuurentStateId { get; set; }

    public int AllowedNewStateId { get; set; }

    public DateTime AddedDate { get; set; }
}
