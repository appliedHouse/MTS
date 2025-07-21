using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtassetType
{
    public int AssetTypeId { get; set; }

    public string AssetType { get; set; } = null!;

    public virtual ICollection<AssetsClassProfile> AssetsClassProfiles { get; set; } = new List<AssetsClassProfile>();
}
