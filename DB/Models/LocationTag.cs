using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LocationTag
{
    public string LocationTagId { get; set; } = null!;

    public int LocationId { get; set; }

    public virtual Location Location { get; set; } = null!;
}
