using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetForm
{
    public int FormId { get; set; }

    public string? FormTitle { get; set; }

    public string FormCode { get; set; } = null!;

    public DateTime FormDate { get; set; }

    public int FormProcessTypeId { get; set; }

    public int FormProcessStateId { get; set; }

    public int FormAssetCount { get; set; }

    public string? FormReportUrl { get; set; }

    public string? FormRefrenceNo { get; set; }

    public string? FormSigns { get; set; }

    public int FormProcessReasonId { get; set; }

    public int? FormProcessedByUserId { get; set; }

    public int? RequestProcessLocationId { get; set; }

    public int? OldEmployeeId { get; set; }

    public int? OldEmployeeDepartmentId { get; set; }

    public int? NewEmployeeId { get; set; }

    public int? NewEmployeeDepartmentId { get; set; }

    public string? Notes { get; set; }

    public int? TempProcessId { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public bool IsDeleted { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual ICollection<AssetAlarmRoleLog> AssetAlarmRoleLogs { get; set; } = new List<AssetAlarmRoleLog>();

    public virtual ICollection<AssetAlarmRole> AssetAlarmRoles { get; set; } = new List<AssetAlarmRole>();

    public virtual ICollection<AssetFormAlarmRoleItem> AssetFormAlarmRoleItems { get; set; } = new List<AssetFormAlarmRoleItem>();

    public virtual AssetFormAuditSession? AssetFormAuditSession { get; set; }

    public virtual AssetFormBoxTransaction? AssetFormBoxTransaction { get; set; }

    public virtual ICollection<AssetFormEditAssetItem> AssetFormEditAssetItems { get; set; } = new List<AssetFormEditAssetItem>();

    public virtual ICollection<AssetFormEditTag> AssetFormEditTags { get; set; } = new List<AssetFormEditTag>();

    public virtual AssetFormEndLife? AssetFormEndLife { get; set; }

    public virtual ICollection<AssetFormGurdianshipItem> AssetFormGurdianshipItems { get; set; } = new List<AssetFormGurdianshipItem>();

    public virtual ICollection<AssetFormItemDistribute> AssetFormItemDistributes { get; set; } = new List<AssetFormItemDistribute>();

    public virtual ICollection<AssetFormLog> AssetFormLogs { get; set; } = new List<AssetFormLog>();

    public virtual ICollection<AssetFormRecievedItem> AssetFormRecievedItemAssetForms { get; set; } = new List<AssetFormRecievedItem>();

    public virtual ICollection<AssetFormRecievedItem> AssetFormRecievedItemExportForms { get; set; } = new List<AssetFormRecievedItem>();

    public virtual ICollection<AssetFormRegistrationItem> AssetFormRegistrationItems { get; set; } = new List<AssetFormRegistrationItem>();

    public virtual ICollection<AssetFormReturnRecieverItem> AssetFormReturnRecieverItemAssetFormTransfares { get; set; } = new List<AssetFormReturnRecieverItem>();

    public virtual ICollection<AssetFormReturnRecieverItem> AssetFormReturnRecieverItemAssetForms { get; set; } = new List<AssetFormReturnRecieverItem>();

    public virtual AssetFormSale? AssetFormSale { get; set; }

    public virtual AssetFormSaleReturn? AssetFormSaleReturn { get; set; }

    public virtual ICollection<AssetFormTransferItem> AssetFormTransferItems { get; set; } = new List<AssetFormTransferItem>();

    public virtual ICollection<AssetFormUserScheule> AssetFormUserScheules { get; set; } = new List<AssetFormUserScheule>();

    public virtual ICollection<Asset> AssetGurdianShipForms { get; set; } = new List<Asset>();

    public virtual AssetMaintenanceForm? AssetMaintenanceForm { get; set; }

    public virtual ICollection<Asset> AssetPendingProcessedForms { get; set; } = new List<Asset>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogGurdianShipForms { get; set; } = new List<AssetTransactionLog>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogNewAssetForms { get; set; } = new List<AssetTransactionLog>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogPendingProcessedForms { get; set; } = new List<AssetTransactionLog>();

    public virtual LtassetTransferReason FormProcessReason { get; set; } = null!;

    public virtual LtformProcessState FormProcessState { get; set; } = null!;

    public virtual LtprocessType FormProcessType { get; set; } = null!;

    public virtual UserAccount? FormProcessedByUser { get; set; }

    public virtual Employee? NewEmployee { get; set; }

    public virtual EmployeeDeparment? NewEmployeeDepartment { get; set; }

    public virtual Employee? OldEmployee { get; set; }

    public virtual EmployeeDeparment? OldEmployeeDepartment { get; set; }

    public virtual Location? RequestProcessLocation { get; set; }

    public virtual TempProcess? TempProcess { get; set; }

    public virtual SystemTransaction? UpdateTransaction { get; set; }

    public virtual ICollection<UserAssetReport> UserAssetReports { get; set; } = new List<UserAssetReport>();

    public virtual ICollection<UserScheduleI> UserScheduleIs { get; set; } = new List<UserScheduleI>();

    public virtual WarehouseForm? WarehouseForm { get; set; }
}
