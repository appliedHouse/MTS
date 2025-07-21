using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormEditAssetItem
{
    public int AssetFormEditAssetItemId { get; set; }

    public int AssetFormId { get; set; }

    public int AssetId { get; set; }

    public int? AssetTransactionId { get; set; }

    public int? NewAssetCode { get; set; }

    public int? NewClassId { get; set; }

    public int? NewUnitId { get; set; }

    public decimal? NewWeight { get; set; }

    public int? NewWeightUnitId { get; set; }

    public int? NewStateId { get; set; }

    public int? NewPlanId { get; set; }

    public DateTime? PlanStartDate { get; set; }

    public int? NewColorId { get; set; }

    public double? NewQuanitiy { get; set; }

    public decimal? NewPrice { get; set; }

    public decimal? NewProfitUnitAmount { get; set; }

    public decimal? NewExtraUnitCost { get; set; }

    public decimal? NewCostPrice { get; set; }

    public decimal? NewSalePrice { get; set; }

    public string? NewReferenceNo { get; set; }

    public string? NewSerialNo { get; set; }

    public string? NewAssetGroupCode { get; set; }

    public string? AssetPhoto { get; set; }

    public string? NewAssetName { get; set; }

    public bool? RemoveAssetPhoto { get; set; }

    public bool? IsContainerNew { get; set; }

    public bool? IsTrackableNew { get; set; }

    public bool? IsDepreciableNew { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual AssetForm AssetForm { get; set; } = null!;

    public virtual AssetTransactionLog? AssetTransaction { get; set; }

    public virtual AssetsClassfication? NewClass { get; set; }

    public virtual Ltcolor? NewColor { get; set; }

    public virtual AssetMaintenancePlan? NewPlan { get; set; }

    public virtual LtassetState? NewState { get; set; }

    public virtual LtassetUnit? NewUnit { get; set; }

    public virtual LtassetUnit? NewWeightUnit { get; set; }
}
