using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetsAndTag
{
    public int? AssetTagId { get; set; }

    public int? AssetId { get; set; }

    public string? TagId { get; set; }

    public int? TagTypeId { get; set; }

    public string? Tid { get; set; }

    public int Expr1 { get; set; }

    public int AssetClassId { get; set; }

    public int AssetCode { get; set; }

    public string? AssetName { get; set; }

    public string? AssetPhoto { get; set; }

    public DateTime? StartMaintancePlanDate { get; set; }

    public int? MaintancePlanId { get; set; }

    public DateTime RegisterDate { get; set; }

    public string? ManufactureSn { get; set; }

    public int AssetUnit { get; set; }

    public int AssetWeightUnit { get; set; }

    public int AssetStateId { get; set; }

    public int MaintenanceStatusId { get; set; }

    public int LocationId { get; set; }

    public int? GurdianShipFormId { get; set; }

    public double Quantity { get; set; }

    public bool IsContainer { get; set; }

    public bool IsInMaintenance { get; set; }

    public bool IsTrackable { get; set; }

    public bool IsRemoved { get; set; }

    public bool IsDepreciable { get; set; }

    public bool IsPendingState { get; set; }

    public bool IsRecieved { get; set; }

    public int? ColorId { get; set; }

    public decimal? Weight { get; set; }

    public int? RealtedAssetId { get; set; }

    public string? AssetGroupCode { get; set; }

    public string? Notes { get; set; }

    public int? PendingProcessedFormId { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Gpslocation { get; set; }

    public DateTime? SaveAssetDate { get; set; }
}
