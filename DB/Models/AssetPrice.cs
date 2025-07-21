using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetPrice
{
    public int AssetId { get; set; }

    public decimal FirstPrice { get; set; }

    public decimal CurrentPrice { get; set; }

    public DateOnly LastPriceDate { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? SalePrice { get; set; }

    public decimal? ExtraUnitCost { get; set; }

    public decimal? ProfitUnitAmount { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual Asset Asset { get; set; } = null!;

    public virtual SystemTransaction? UpdateTransaction { get; set; }
}
