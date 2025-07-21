using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class ViewRiyadh
{
    public int AssetId { get; set; }

    public int AssetClassId { get; set; }

    public int LocationId { get; set; }

    public string LocationName { get; set; } = null!;

    public string? LocationNameEn { get; set; }

    public string? LocationCode { get; set; }
}
