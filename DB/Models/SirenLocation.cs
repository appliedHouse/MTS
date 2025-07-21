using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class SirenLocation
{
    public int SirenLocationId { get; set; }

    public int SirenId { get; set; }

    public int LocationId { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual Siren Siren { get; set; } = null!;
}
