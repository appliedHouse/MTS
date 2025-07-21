using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtassetState
{
    public int AssetStateId { get; set; }

    public string AssetState { get; set; } = null!;

    public bool IsSystemValue { get; set; }

    public bool IsDisableTracking { get; set; }

    public virtual ICollection<AssetFormEditAssetItem> AssetFormEditAssetItems { get; set; } = new List<AssetFormEditAssetItem>();

    public virtual ICollection<AssetFormGurdianshipItem> AssetFormGurdianshipItemNewStateStates { get; set; } = new List<AssetFormGurdianshipItem>();

    public virtual ICollection<AssetFormGurdianshipItem> AssetFormGurdianshipItemOldAssetStates { get; set; } = new List<AssetFormGurdianshipItem>();

    public virtual ICollection<AssetFormTransferItem> AssetFormTransferItemNewAssetStates { get; set; } = new List<AssetFormTransferItem>();

    public virtual ICollection<AssetFormTransferItem> AssetFormTransferItemOldAssetStates { get; set; } = new List<AssetFormTransferItem>();

    public virtual ICollection<AssetReuseFormDetail> AssetReuseFormDetails { get; set; } = new List<AssetReuseFormDetail>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogs { get; set; } = new List<AssetTransactionLog>();

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();

    public virtual ICollection<SystemAssetStateRule> SystemAssetStateRuleAllowedNewStates { get; set; } = new List<SystemAssetStateRule>();

    public virtual ICollection<SystemAssetStateRule> SystemAssetStateRuleCuurentStates { get; set; } = new List<SystemAssetStateRule>();

    public virtual ICollection<TempProcessGuardenItem> TempProcessGuardenItems { get; set; } = new List<TempProcessGuardenItem>();

    public virtual ICollection<TempProcessRegistrationItemLog> TempProcessRegistrationItemLogs { get; set; } = new List<TempProcessRegistrationItemLog>();

    public virtual ICollection<TempProcessRegistrationItem> TempProcessRegistrationItems { get; set; } = new List<TempProcessRegistrationItem>();

    public virtual ICollection<TempProcessReturnItem> TempProcessReturnItems { get; set; } = new List<TempProcessReturnItem>();

    public virtual ICollection<TempProcessTransferItem> TempProcessTransferItems { get; set; } = new List<TempProcessTransferItem>();

    public virtual ICollection<WarehousReturnFormItem> WarehousReturnFormItems { get; set; } = new List<WarehousReturnFormItem>();
}
