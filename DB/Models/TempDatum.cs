using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class TempDatum
{
    public int TempDataId { get; set; }

    public string Data { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Refrence { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }
}
