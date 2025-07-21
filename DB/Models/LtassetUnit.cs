using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtassetUnit
{
    public int AssetUnitId { get; set; }

    public string AssetUnitKey { get; set; } = null!;

    public bool IsForWeight { get; set; }

    public virtual ICollection<Asset> AssetAssetUnitNavigations { get; set; } = new List<Asset>();

    public virtual ICollection<Asset> AssetAssetWeightUnitNavigations { get; set; } = new List<Asset>();

    public virtual ICollection<AssetFormEditAssetItem> AssetFormEditAssetItemNewUnits { get; set; } = new List<AssetFormEditAssetItem>();

    public virtual ICollection<AssetFormEditAssetItem> AssetFormEditAssetItemNewWeightUnits { get; set; } = new List<AssetFormEditAssetItem>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogAssetUnitNavigations { get; set; } = new List<AssetTransactionLog>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogAssetWeightUnitNavigations { get; set; } = new List<AssetTransactionLog>();

    public virtual ICollection<AssetsClassProfile> AssetsClassProfileItemDefualtUnitNavigations { get; set; } = new List<AssetsClassProfile>();

    public virtual ICollection<AssetsClassProfile> AssetsClassProfileWeightDefualtUnitNavigations { get; set; } = new List<AssetsClassProfile>();

    public virtual ICollection<TempProcessRegistrationItemLog> TempProcessRegistrationItemLogs { get; set; } = new List<TempProcessRegistrationItemLog>();

    public virtual ICollection<TempProcessRegistrationItem> TempProcessRegistrationItemUnitNavigations { get; set; } = new List<TempProcessRegistrationItem>();

    public virtual ICollection<TempProcessRegistrationItem> TempProcessRegistrationItemWeightUnits { get; set; } = new List<TempProcessRegistrationItem>();

    public virtual ICollection<WarehouseExportFormItem> WarehouseExportFormItems { get; set; } = new List<WarehouseExportFormItem>();

    public virtual ICollection<WarehouseImportFormItem> WarehouseImportFormItems { get; set; } = new List<WarehouseImportFormItem>();
}
