using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Rfidscreen
{
    public int HardwareId { get; set; }

    public int ScreenType { get; set; }

    public string? ScreenName { get; set; }

    public string? ScreenDescription { get; set; }

    public virtual Hardware Hardware { get; set; } = null!;
}
