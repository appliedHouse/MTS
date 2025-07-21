using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class DepreciationPlan
{
    public int DepreciationPlanId { get; set; }

    public string Title { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public DateTime? DepreciationDate { get; set; }

    public Guid TransactionId { get; set; }

    public virtual ICollection<AssetDepreciation> AssetDepreciations { get; set; } = new List<AssetDepreciation>();

    public virtual SystemTransaction Transaction { get; set; } = null!;
}
