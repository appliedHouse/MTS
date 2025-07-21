using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Asset
{
    public int AssetId { get; set; }

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

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual ICollection<AlarmActiveAsset> AlarmActiveAssets { get; set; } = new List<AlarmActiveAsset>();

    public virtual ICollection<AlarmPassiveAsset> AlarmPassiveAssets { get; set; } = new List<AlarmPassiveAsset>();

    public virtual AssetAlarmRole? AssetAlarmRole { get; set; }

    public virtual ICollection<AssetAlarmRoleLog> AssetAlarmRoleLogs { get; set; } = new List<AssetAlarmRoleLog>();

    public virtual ICollection<AssetAttachment> AssetAttachments { get; set; } = new List<AssetAttachment>();

    public virtual AssetsClassfication AssetClass { get; set; } = null!;

    public virtual ICollection<AssetDepreciation> AssetDepreciations { get; set; } = new List<AssetDepreciation>();

    public virtual ICollection<AssetFormAlarmRoleItem> AssetFormAlarmRoleItems { get; set; } = new List<AssetFormAlarmRoleItem>();

    public virtual ICollection<AssetFormBoxTransactionItem> AssetFormBoxTransactionItems { get; set; } = new List<AssetFormBoxTransactionItem>();

    public virtual ICollection<AssetFormEditAssetItem> AssetFormEditAssetItems { get; set; } = new List<AssetFormEditAssetItem>();

    public virtual ICollection<AssetFormEndLifeItem> AssetFormEndLifeItems { get; set; } = new List<AssetFormEndLifeItem>();

    public virtual ICollection<AssetFormGurdianshipItem> AssetFormGurdianshipItems { get; set; } = new List<AssetFormGurdianshipItem>();

    public virtual ICollection<AssetFormItemDistribute> AssetFormItemDistributes { get; set; } = new List<AssetFormItemDistribute>();

    public virtual ICollection<AssetFormMaintenanceItem> AssetFormMaintenanceItems { get; set; } = new List<AssetFormMaintenanceItem>();

    public virtual ICollection<AssetFormRecievedItem> AssetFormRecievedItems { get; set; } = new List<AssetFormRecievedItem>();

    public virtual ICollection<AssetFormRegistrationItem> AssetFormRegistrationItems { get; set; } = new List<AssetFormRegistrationItem>();

    public virtual ICollection<AssetFormReturnRecieverItem> AssetFormReturnRecieverItems { get; set; } = new List<AssetFormReturnRecieverItem>();

    public virtual ICollection<AssetFormSaleIncomItem> AssetFormSaleIncomItemContainerAssets { get; set; } = new List<AssetFormSaleIncomItem>();

    public virtual ICollection<AssetFormSaleIncomItem> AssetFormSaleIncomItemIncomeAssets { get; set; } = new List<AssetFormSaleIncomItem>();

    public virtual ICollection<AssetFormSaleItem> AssetFormSaleItems { get; set; } = new List<AssetFormSaleItem>();

    public virtual ICollection<AssetFormTransferItem> AssetFormTransferItems { get; set; } = new List<AssetFormTransferItem>();

    public virtual AssetPrice? AssetPrice { get; set; }

    public virtual ICollection<AssetReuseFormDetail> AssetReuseFormDetails { get; set; } = new List<AssetReuseFormDetail>();

    public virtual LtassetState AssetState { get; set; } = null!;

    public virtual ICollection<AssetTagTransactionLog> AssetTagTransactionLogs { get; set; } = new List<AssetTagTransactionLog>();

    public virtual ICollection<AssetTag> AssetTags { get; set; } = new List<AssetTag>();

    public virtual ICollection<AssetTracking> AssetTrackings { get; set; } = new List<AssetTracking>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogAssets { get; set; } = new List<AssetTransactionLog>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogRealtedAssets { get; set; } = new List<AssetTransactionLog>();

    public virtual LtassetUnit AssetUnitNavigation { get; set; } = null!;

    public virtual ICollection<AssetWarehouse> AssetWarehouses { get; set; } = new List<AssetWarehouse>();

    public virtual LtassetUnit AssetWeightUnitNavigation { get; set; } = null!;

    public virtual ICollection<AuditSessionPresentAsset> AuditSessionPresentAssets { get; set; } = new List<AuditSessionPresentAsset>();

    public virtual Ltcolor? Color { get; set; }

    public virtual ICollection<CustomFieldsValue> CustomFieldsValues { get; set; } = new List<CustomFieldsValue>();

    public virtual ICollection<ExtraGeofencedAsset> ExtraGeofencedAssets { get; set; } = new List<ExtraGeofencedAsset>();

    public virtual AssetForm? GurdianShipForm { get; set; }

    public virtual ICollection<Asset> InverseRealtedAsset { get; set; } = new List<Asset>();

    public virtual Location Location { get; set; } = null!;

    public virtual AssetMaintenancePlan? MaintancePlan { get; set; }

    public virtual LtassetMaintenanceStatus MaintenanceStatus { get; set; } = null!;

    public virtual ICollection<MissingAsset> MissingAssets { get; set; } = new List<MissingAsset>();

    public virtual ICollection<MissingGeofencedAsset> MissingGeofencedAssets { get; set; } = new List<MissingGeofencedAsset>();

    public virtual AssetForm? PendingProcessedForm { get; set; }

    public virtual Asset? RealtedAsset { get; set; }

    public virtual ICollection<TempProcessEditItem> TempProcessEditItems { get; set; } = new List<TempProcessEditItem>();

    public virtual ICollection<TempProcessGuardenItem> TempProcessGuardenItems { get; set; } = new List<TempProcessGuardenItem>();

    public virtual ICollection<TempProcessRegeofencingItem> TempProcessRegeofencingItems { get; set; } = new List<TempProcessRegeofencingItem>();

    public virtual ICollection<TempProcessTransferItem> TempProcessTransferItems { get; set; } = new List<TempProcessTransferItem>();

    public virtual SystemTransaction? UpdateTransaction { get; set; }

    public virtual ICollection<WarehousReturnFormItem> WarehousReturnFormItems { get; set; } = new List<WarehousReturnFormItem>();
}
