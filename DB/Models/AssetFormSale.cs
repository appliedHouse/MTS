using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormSale
{
    public int AssetFormId { get; set; }

    public string Reciver { get; set; } = null!;

    public string? ReciverTaxNum { get; set; }

    public int SellerUserId { get; set; }

    public decimal TotalPrice { get; set; }

    public decimal TotalTaxes { get; set; }

    public decimal TotalDiscount { get; set; }

    public decimal NetPrice { get; set; }

    public int? OriginalFormId { get; set; }

    public int PoSid { get; set; }

    public int LocationId { get; set; }

    public int? PaymentMethodId { get; set; }

    public DateTime CreateDate { get; set; }

    public virtual AssetForm AssetForm { get; set; } = null!;

    public virtual AssetFormSaleFin? AssetFormSaleFin { get; set; }

    public virtual ICollection<AssetFormSaleIncomItem> AssetFormSaleIncomItems { get; set; } = new List<AssetFormSaleIncomItem>();

    public virtual ICollection<AssetFormSaleItem> AssetFormSaleItems { get; set; } = new List<AssetFormSaleItem>();

    public virtual ICollection<AssetFormSaleReturn> AssetFormSaleReturns { get; set; } = new List<AssetFormSaleReturn>();

    public virtual ICollection<AssetFormSale> InverseOriginalForm { get; set; } = new List<AssetFormSale>();

    public virtual Location Location { get; set; } = null!;

    public virtual AssetFormSale? OriginalForm { get; set; }

    public virtual LtpaymentMethod? PaymentMethod { get; set; }

    public virtual SystemApp PoS { get; set; } = null!;

    public virtual UserAccount SellerUser { get; set; } = null!;
}
