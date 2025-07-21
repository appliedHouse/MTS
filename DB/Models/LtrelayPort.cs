using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtrelayPort
{
    public int RelayPortId { get; set; }

    public string RelayPortName { get; set; } = null!;

    public string RelayIod { get; set; } = null!;

    public virtual ICollection<Siren> Sirens { get; set; } = new List<Siren>();
}
