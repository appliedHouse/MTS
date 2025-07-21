using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class RfidhandHeld
{
    public int HandHeldId { get; set; }

    public string Macaddress { get; set; } = null!;
}
