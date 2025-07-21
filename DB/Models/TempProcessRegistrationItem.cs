using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class TempProcessRegistrationItem
{
    public int ProcessId { get; set; }

    public int TempProcessId { get; set; }

    public int? PendingAssetRegistrationForm { get; set; }

    public string? RefrenceNo { get; set; }

    public DateTime AddDate { get; set; }

    public int AssetClassId { get; set; }

    public int LocationId { get; set; }

    public int Unit { get; set; }

    public int WeightUnitId { get; set; }

    public double Quantity { get; set; }

    public int AssetStateId { get; set; }

    public bool IsContainer { get; set; }

    public bool IsRegistered { get; set; }

    public bool IsTrackable { get; set; }

    public bool IsDepreciable { get; set; }

    public bool IsPendingState { get; set; }

    public decimal? AssetPrice { get; set; }

    public string? ManufactureSn { get; set; }

    public string? AssetPhoto { get; set; }

    public int? MaintancePlanId { get; set; }

    public DateOnly? StartMaintancePlanDate { get; set; }

    public int? ColorId { get; set; }

    public double? Weight { get; set; }

    public int? RealtedAssetTransactionId { get; set; }

    public string? Notes { get; set; }

    public string? AssetGroupCode { get; set; }

    public decimal? ProfitUnitAmount { get; set; }

    public decimal? ExtraUnitCost { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? SalePrice { get; set; }

    public virtual AssetsClassfication AssetClass { get; set; } = null!;

    public virtual ICollection<AssetFormRegistrationItem> AssetFormRegistrationItems { get; set; } = new List<AssetFormRegistrationItem>();

    public virtual LtassetState AssetState { get; set; } = null!;

    public virtual Ltcolor? Color { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual AssetMaintenancePlan? MaintancePlan { get; set; }

    public virtual AssetTransactionLog? RealtedAssetTransaction { get; set; }

    public virtual ICollection<TempAssetTag> TempAssetTags { get; set; } = new List<TempAssetTag>();

    public virtual TempProcess TempProcess { get; set; } = null!;

    public virtual ICollection<TempProcessCustomFieldDatum> TempProcessCustomFieldData { get; set; } = new List<TempProcessCustomFieldDatum>();

    public virtual LtassetUnit UnitNavigation { get; set; } = null!;

    public virtual LtassetUnit WeightUnit { get; set; } = null!;
}
