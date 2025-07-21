using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class TempProcessRegistrationItemLog
{
    public int LogId { get; set; }

    public int ProcessId { get; set; }

    public int TempAssetProcessId { get; set; }

    public string? RefrenceNo { get; set; }

    public DateTime AddDate { get; set; }

    public int AssetClassId { get; set; }

    public int LocationId { get; set; }

    public int Unit { get; set; }

    public double Quantity { get; set; }

    public int AssetStateId { get; set; }

    public bool IsContainer { get; set; }

    public bool IsRegistered { get; set; }

    public bool IsTrackable { get; set; }

    public decimal? AssetPrice { get; set; }

    public string? ManufactureSn { get; set; }

    public string? AssetPhoto { get; set; }

    public DateTime LogDate { get; set; }

    public int? ColorId { get; set; }

    public double? Weight { get; set; }

    public int? RealtedAssetTransactionId { get; set; }

    public string? Notes { get; set; }

    public string? AssetGroupCode { get; set; }

    public virtual AssetsClassfication AssetClass { get; set; } = null!;

    public virtual LtassetState AssetState { get; set; } = null!;

    public virtual Ltcolor? Color { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual AssetTransactionLog? RealtedAssetTransaction { get; set; }

    public virtual TempProcess TempAssetProcess { get; set; } = null!;

    public virtual LtassetUnit UnitNavigation { get; set; } = null!;
}
