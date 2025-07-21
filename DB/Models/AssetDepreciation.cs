using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetDepreciation
{
    public int AssetDepreciationId { get; set; }

    public int AssetId { get; set; }

    public double DepreciationValue { get; set; }

    public int DepreciationPlanId { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual DepreciationPlan DepreciationPlan { get; set; } = null!;
}
