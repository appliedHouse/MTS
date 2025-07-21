using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class SecurityGuard
{
    public int GuardId { get; set; }

    public string ContactName { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public bool InformWithMissingGeofencedAssets { get; set; }

    public bool InformWithMissingAssets { get; set; }

    public bool InformWithRfidreaderStatus { get; set; }

    public bool ShouldContactViaSms { get; set; }

    public bool ShouldContactViaEmail { get; set; }

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
