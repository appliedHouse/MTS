using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtlocationType
{
    public int LocationTypeId { get; set; }

    public string LocationTypeText { get; set; } = null!;

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
