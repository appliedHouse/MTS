using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetTracking
{
    public int AssetTrackingId { get; set; }

    public int AssetId { get; set; }

    public int LocationId { get; set; }

    public int? ZoneId { get; set; }

    public DateTime Date { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual Zone? Zone { get; set; }
}
