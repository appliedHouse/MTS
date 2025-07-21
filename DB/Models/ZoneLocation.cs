using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class ZoneLocation
{
    public int ZoneLocationId { get; set; }

    public int ZoneId { get; set; }

    public int LocationId { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual Zone Zone { get; set; } = null!;
}
