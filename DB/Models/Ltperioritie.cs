using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Ltperioritie
{
    public int PeriorityId { get; set; }

    public string Name { get; set; } = null!;

    public int PeriorityOrder { get; set; }
}
