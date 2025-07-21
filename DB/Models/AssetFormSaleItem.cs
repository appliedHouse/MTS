using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormSaleItem
{
    public int AssetFormSaleItemId { get; set; }

    public int AssetFormId { get; set; }

    public int AssetId { get; set; }

    public int? AssetTransactionId { get; set; }

    public decimal OrignalWieght { get; set; }

    public decimal SaleWeight { get; set; }

    public decimal? SaleStonesPercentage { get; set; }

    public double? OrignalQuantity { get; set; }

    public double? SaleQuantity { get; set; }

    public decimal OriginalProfitUnitAmount { get; set; }

    public decimal SaleProfitUnitAmount { get; set; }

    public decimal OriginalExtraUnitCost { get; set; }

    public decimal SaleExtraUnitCost { get; set; }

    public decimal OrignalUnitPrice { get; set; }

    public decimal SaleUnitPrice { get; set; }

    public decimal Tax { get; set; }

    public decimal? TaxesPercentage { get; set; }

    public decimal PriceBeforeVat { get; set; }

    public decimal PriceAfterVat { get; set; }

    public decimal OrignalPrice { get; set; }

    public decimal SalePrice { get; set; }

    public decimal Discount { get; set; }

    public int? CancelReasonId { get; set; }

    public bool IsCanceled { get; set; }

    public int? ModifyFormId { get; set; }

    public int SellerUserId { get; set; }

    public string? SaleItemRefCode { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual AssetFormSale AssetForm { get; set; } = null!;

    public virtual ICollection<AssetFormSaleReturnItem> AssetFormSaleReturnItems { get; set; } = new List<AssetFormSaleReturnItem>();

    public virtual AssetTransactionLog? AssetTransaction { get; set; }
}
