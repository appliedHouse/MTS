using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormSaleIncomItem
{
    public int AssetFormSaleIncomItemId { get; set; }

    public int AssetFormSaleFormId { get; set; }

    public int ContainerAssetId { get; set; }

    public int? ContainerAssetTransactionId { get; set; }

    public decimal OrignalWeight { get; set; }

    public double OrignalQuantity { get; set; }

    public decimal CurrentWeight { get; set; }

    public double CurrentQuantity { get; set; }

    public int IncomeAssetId { get; set; }

    public int? IncomeAssetTransactionId { get; set; }

    public decimal AddedWeight { get; set; }

    public double AddedQuantity { get; set; }

    public virtual AssetFormSale AssetFormSaleForm { get; set; } = null!;

    public virtual Asset ContainerAsset { get; set; } = null!;

    public virtual AssetTransactionLog? ContainerAssetTransaction { get; set; }

    public virtual Asset IncomeAsset { get; set; } = null!;

    public virtual AssetTransactionLog? IncomeAssetTransaction { get; set; }
}
