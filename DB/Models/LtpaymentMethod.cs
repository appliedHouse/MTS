using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtpaymentMethod
{
    public int PaymentMethodId { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public decimal? CostPercentageLevel1 { get; set; }

    public decimal? CostLevel12 { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<AssetFormSaleReturn> AssetFormSaleReturns { get; set; } = new List<AssetFormSaleReturn>();

    public virtual ICollection<AssetFormSale> AssetFormSales { get; set; } = new List<AssetFormSale>();
}
