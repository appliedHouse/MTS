using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormSaleReturnItem
{
    public int AssetFormSaleReturnItemId { get; set; }

    public int AssetFormSaleReturnFormId { get; set; }

    public int AssetFormSaleItemId { get; set; }

    public int AssetTransactionId { get; set; }

    public decimal ReturnedWeight { get; set; }

    public decimal ReturnedQuantity { get; set; }

    public decimal Tax { get; set; }

    public decimal TaxesPercentage { get; set; }

    public decimal PriceBeforeVat { get; set; }

    public decimal PriceAfterVat { get; set; }

    public decimal Discount { get; set; }

    public virtual AssetFormSaleItem AssetFormSaleItem { get; set; } = null!;

    public virtual AssetFormSaleReturn AssetFormSaleReturnForm { get; set; } = null!;

    public virtual AssetTransactionLog AssetTransaction { get; set; } = null!;
}
