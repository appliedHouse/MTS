using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class ExtraGeofencedAsset
{
    public int ExtraGeofencedAssetId { get; set; }

    public DateTime ExtraDate { get; set; }

    public int AuditSessionId { get; set; }

    public int AssetId { get; set; }

    public int CurrentLocationId { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual Location CurrentLocation { get; set; } = null!;
}
