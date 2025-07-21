using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormSaleReturn
{
    public int AssetFormId { get; set; }

    public string SaleReturnFormCode { get; set; } = null!;

    public int AssetSaleFormId { get; set; }

    public int SellerUserId { get; set; }

    public decimal TotalPrice { get; set; }

    public decimal TotalTaxes { get; set; }

    public decimal TotalDiscount { get; set; }

    public decimal NetPrice { get; set; }

    public int PoSid { get; set; }

    public int LocationId { get; set; }

    public int? PaymentMethodId { get; set; }

    public DateTime CreateDate { get; set; }

    public virtual AssetForm AssetForm { get; set; } = null!;

    public virtual ICollection<AssetFormSaleReturnItem> AssetFormSaleReturnItems { get; set; } = new List<AssetFormSaleReturnItem>();

    public virtual AssetFormSale AssetSaleForm { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual LtpaymentMethod? PaymentMethod { get; set; }

    public virtual SystemApp PoS { get; set; } = null!;

    public virtual UserAccount SellerUser { get; set; } = null!;
}
