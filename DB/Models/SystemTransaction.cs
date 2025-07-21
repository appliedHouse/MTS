using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class SystemTransaction
{
    public Guid TransactionId { get; set; }

    public string TransactionName { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public int TransactionByUserId { get; set; }

    public int TransactionType { get; set; }

    public virtual ICollection<Asset> AssetAddTransactions { get; set; } = new List<Asset>();

    public virtual ICollection<AssetAlarmRoleLog> AssetAlarmRoleLogs { get; set; } = new List<AssetAlarmRoleLog>();

    public virtual ICollection<AssetAlarmRole> AssetAlarmRoles { get; set; } = new List<AssetAlarmRole>();

    public virtual ICollection<AssetAttachment> AssetAttachmentAddTransactions { get; set; } = new List<AssetAttachment>();

    public virtual ICollection<AssetAttachment> AssetAttachmentUpdateTransactions { get; set; } = new List<AssetAttachment>();

    public virtual ICollection<AssetForm> AssetFormAddTransactions { get; set; } = new List<AssetForm>();

    public virtual ICollection<AssetFormLog> AssetFormLogs { get; set; } = new List<AssetFormLog>();

    public virtual ICollection<AssetForm> AssetFormUpdateTransactions { get; set; } = new List<AssetForm>();

    public virtual ICollection<AssetMaintenancePlan> AssetMaintenancePlanAddTransactions { get; set; } = new List<AssetMaintenancePlan>();

    public virtual ICollection<AssetMaintenancePlan> AssetMaintenancePlanUpdateTransactions { get; set; } = new List<AssetMaintenancePlan>();

    public virtual ICollection<AssetPrice> AssetPriceAddTransactions { get; set; } = new List<AssetPrice>();

    public virtual ICollection<AssetPrice> AssetPriceUpdateTransactions { get; set; } = new List<AssetPrice>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogAddTransactions { get; set; } = new List<AssetTransactionLog>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogUpdateTransactions { get; set; } = new List<AssetTransactionLog>();

    public virtual ICollection<Asset> AssetUpdateTransactions { get; set; } = new List<Asset>();

    public virtual ICollection<AssetsClassProfile> AssetsClassProfileAddTransactions { get; set; } = new List<AssetsClassProfile>();

    public virtual ICollection<AssetsClassProfile> AssetsClassProfileUpdateTransactions { get; set; } = new List<AssetsClassProfile>();

    public virtual ICollection<AssetsClassfication> AssetsClassficationAddTransactions { get; set; } = new List<AssetsClassfication>();

    public virtual ICollection<AssetsClassfication> AssetsClassficationUpdateTransactions { get; set; } = new List<AssetsClassfication>();

    public virtual ICollection<DepreciationPlan> DepreciationPlans { get; set; } = new List<DepreciationPlan>();

    public virtual ICollection<EmployeeDeparment> EmployeeDeparments { get; set; } = new List<EmployeeDeparment>();

    public virtual ICollection<EmployeeSign> EmployeeSigns { get; set; } = new List<EmployeeSign>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<GroupPrivilege> GroupPrivileges { get; set; } = new List<GroupPrivilege>();

    public virtual ICollection<Hardware> HardwareAddTransactions { get; set; } = new List<Hardware>();

    public virtual ICollection<Hardware> HardwareUpdateTransactions { get; set; } = new List<Hardware>();

    public virtual ICollection<LiteUserService> LiteUserServices { get; set; } = new List<LiteUserService>();

    public virtual ICollection<Location> LocationAddTransactions { get; set; } = new List<Location>();

    public virtual ICollection<Location> LocationUpdateTransactions { get; set; } = new List<Location>();

    public virtual ICollection<Rfidantenna> RfidantennaAddTransactions { get; set; } = new List<Rfidantenna>();

    public virtual ICollection<Rfidantenna> RfidantennaUpdateTransactions { get; set; } = new List<Rfidantenna>();

    public virtual ICollection<Siren> SirenAddTransactions { get; set; } = new List<Siren>();

    public virtual ICollection<SirenRole> SirenRoleAddTransactions { get; set; } = new List<SirenRole>();

    public virtual ICollection<SirenRole> SirenRoleUpdateTransactions { get; set; } = new List<SirenRole>();

    public virtual ICollection<Siren> SirenUpdateTransactions { get; set; } = new List<Siren>();

    public virtual ICollection<Switch> SwitchAddTransactions { get; set; } = new List<Switch>();

    public virtual ICollection<Switch> SwitchUpdateTransactions { get; set; } = new List<Switch>();

    public virtual ICollection<SystemAlarmRole> SystemAlarmRoleAddTransactions { get; set; } = new List<SystemAlarmRole>();

    public virtual ICollection<SystemAlarmRole> SystemAlarmRoleUpdateTransactions { get; set; } = new List<SystemAlarmRole>();

    public virtual ICollection<SystemCore> SystemCoreAddTransactions { get; set; } = new List<SystemCore>();

    public virtual ICollection<SystemCore> SystemCoreUpdateTransactions { get; set; } = new List<SystemCore>();

    public virtual ICollection<SystemSetting> SystemSettings { get; set; } = new List<SystemSetting>();

    public virtual UserAccount TransactionByUser { get; set; } = null!;

    public virtual ICollection<UserAccessLocation> UserAccessLocations { get; set; } = new List<UserAccessLocation>();

    public virtual ICollection<UserAccount> UserAccountAddTransactions { get; set; } = new List<UserAccount>();

    public virtual ICollection<UserAccount> UserAccountUpdateTransactions { get; set; } = new List<UserAccount>();

    public virtual ICollection<UserGroup> UserGroupAddTransactions { get; set; } = new List<UserGroup>();

    public virtual ICollection<UserGroup> UserGroupUpdateTransactions { get; set; } = new List<UserGroup>();

    public virtual ICollection<UserProcessType> UserProcessTypes { get; set; } = new List<UserProcessType>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    public virtual ICollection<WarehouseManager> WarehouseManagerAddTransactions { get; set; } = new List<WarehouseManager>();

    public virtual ICollection<WarehouseManager> WarehouseManagerUpdateTransactions { get; set; } = new List<WarehouseManager>();

    public virtual ICollection<Zone> ZoneAddTransactions { get; set; } = new List<Zone>();

    public virtual ICollection<Zone> ZoneUpdateTransactions { get; set; } = new List<Zone>();
}
