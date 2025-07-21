using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class MissingAsset
{
    public int MissingAssetId { get; set; }

    public int AssetId { get; set; }

    public DateTime MissingDate { get; set; }

    public DateTime? AddDate { get; set; }

    public int? AddUserId { get; set; }

    public DateTime? ModfiyDate { get; set; }

    public int? ModfiyUserId { get; set; }

    public virtual UserAccount? AddUser { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual UserAccount? ModfiyUser { get; set; }
}
