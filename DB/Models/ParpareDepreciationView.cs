using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class ParpareDepreciationView
{
    public int AssetId { get; set; }

    public bool IsDepreciable { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public DateTime RegisterDate { get; set; }

    public double DepreciationPercentage { get; set; }

    public DateTime? BeginDate { get; set; }

    public decimal FirstPrice { get; set; }

    public decimal CurrentPrice { get; set; }

    public string Title { get; set; } = null!;

    public int DepreciationPlanId { get; set; }

    public double? NewDepValue { get; set; }

    public double? DeprecaitionAmount { get; set; }

    public double? NewPrice { get; set; }
}
