using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class RfidroomLocator
{
    public int RoomLocatorId { get; set; }

    public int LocationId { get; set; }

    public int RoomLocatorType { get; set; }

    public virtual ICollection<AlarmActiveAsset> AlarmActiveAssets { get; set; } = new List<AlarmActiveAsset>();

    public virtual Location Location { get; set; } = null!;
}
