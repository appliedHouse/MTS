using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class MissingGeofencedAsset
{
    public int MissingGeofencedAssetId { get; set; }

    public int GeofencedLocationId { get; set; }

    public DateTime MissingDate { get; set; }

    public int AssetId { get; set; }

    public int AuditSessionId { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual Location GeofencedLocation { get; set; } = null!;
}
