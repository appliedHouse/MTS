using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class SirenRelay
{
    public int HardwareId { get; set; }

    public string Title { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual Hardware Hardware { get; set; } = null!;

    public virtual ICollection<Siren> Sirens { get; set; } = new List<Siren>();
}
