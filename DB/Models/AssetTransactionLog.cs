using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetTransactionLog
{
    public int AssetTransactionId { get; set; }

    public int AssetId { get; set; }

    public int AssetClassId { get; set; }

    public int AssetCode { get; set; }

    public string? AssetName { get; set; }

    public string? AssetPhoto { get; set; }

    public DateTime? StartMaintancePlanDate { get; set; }

    public int? MaintancePlanId { get; set; }

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

    public int? PendingProcessedFormId { get; set; }

    public decimal AssetPrice { get; set; }

    public int? ColorId { get; set; }

    public decimal? Weight { get; set; }

    public int? RealtedAssetId { get; set; }

    public string? Notes { get; set; }

    public int? UserId { get; set; }

    public Guid? AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public DateTime TransactionDate { get; set; }

    public int TransactionReasoneId { get; set; }

    public int ProcessTypeId { get; set; }

    public int NewAssetFormId { get; set; }

    public string? AssetGroupCode { get; set; }

    public decimal? ProfitUnitAmount { get; set; }

    public decimal? ExtraUnitCost { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? SalePrice { get; set; }

    public virtual SystemTransaction? AddTransaction { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual AssetsClassfication AssetClass { get; set; } = null!;

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

    public virtual ICollection<AssetFormSaleIncomItem> AssetFormSaleIncomItemContainerAssetTransactions { get; set; } = new List<AssetFormSaleIncomItem>();

    public virtual ICollection<AssetFormSaleIncomItem> AssetFormSaleIncomItemIncomeAssetTransactions { get; set; } = new List<AssetFormSaleIncomItem>();

    public virtual ICollection<AssetFormSaleItem> AssetFormSaleItems { get; set; } = new List<AssetFormSaleItem>();

    public virtual ICollection<AssetFormSaleReturnItem> AssetFormSaleReturnItems { get; set; } = new List<AssetFormSaleReturnItem>();

    public virtual ICollection<AssetFormTransferItem> AssetFormTransferItems { get; set; } = new List<AssetFormTransferItem>();

    public virtual LtassetState AssetState { get; set; } = null!;

    public virtual ICollection<AssetTagTransactionLog> AssetTagTransactionLogs { get; set; } = new List<AssetTagTransactionLog>();

    public virtual LtassetUnit AssetUnitNavigation { get; set; } = null!;

    public virtual LtassetUnit AssetWeightUnitNavigation { get; set; } = null!;

    public virtual ICollection<AuditSessionPresentAsset> AuditSessionPresentAssets { get; set; } = new List<AuditSessionPresentAsset>();

    public virtual Ltcolor? Color { get; set; }

    public virtual AssetForm? GurdianShipForm { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual AssetMaintenancePlan? MaintancePlan { get; set; }

    public virtual LtassetMaintenanceStatus MaintenanceStatus { get; set; } = null!;

    public virtual AssetForm NewAssetForm { get; set; } = null!;

    public virtual AssetForm? PendingProcessedForm { get; set; }

    public virtual LtprocessType ProcessType { get; set; } = null!;

    public virtual Asset? RealtedAsset { get; set; }

    public virtual ICollection<TempProcessRegistrationItemLog> TempProcessRegistrationItemLogs { get; set; } = new List<TempProcessRegistrationItemLog>();

    public virtual ICollection<TempProcessRegistrationItem> TempProcessRegistrationItems { get; set; } = new List<TempProcessRegistrationItem>();

    public virtual LtassetTransferReason TransactionReasone { get; set; } = null!;

    public virtual SystemTransaction? UpdateTransaction { get; set; }

    public virtual UserAccount? User { get; set; }

    public virtual ICollection<WarehousReturnFormItem> WarehousReturnFormItems { get; set; } = new List<WarehousReturnFormItem>();
}
