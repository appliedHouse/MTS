using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class DeprceationDataView
{
    public int AssetId { get; set; }

    public int AssetClassId { get; set; }

    public int? DepreciationCount { get; set; }

    public double DepreciationValue { get; set; }

    public decimal FirstPrice { get; set; }

    public decimal CurrentPrice { get; set; }

    public string ClassName { get; set; } = null!;

    public string? ParentClassPath { get; set; }

    public int AssetCode { get; set; }

    public string? ClassCode { get; set; }

    public string ClassImage { get; set; } = null!;

    public string? AssetPhoto { get; set; }

    public string LocationTypeText { get; set; } = null!;

    public string LocationName { get; set; } = null!;

    public string? LocationCode { get; set; }

    public string? LocationParentPath { get; set; }
}
