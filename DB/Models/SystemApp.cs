using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class SystemApp
{
    public int SystemAppId { get; set; }

    public int AppTypeId { get; set; }

    public DateTime? RegisterDate { get; set; }

    public int? LocationId { get; set; }

    public int? LicenseId { get; set; }

    public virtual LtsystemAppType AppType { get; set; } = null!;

    public virtual ICollection<AssetFormSaleReturn> AssetFormSaleReturns { get; set; } = new List<AssetFormSaleReturn>();

    public virtual ICollection<AssetFormSale> AssetFormSales { get; set; } = new List<AssetFormSale>();

    public virtual License? License { get; set; }

    public virtual Location? Location { get; set; }
}
