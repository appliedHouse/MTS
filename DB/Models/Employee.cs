using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? EmployeePhoto { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string? EmployeeSocialId { get; set; }

    public int DepartmentId { get; set; }

    public Guid TransactionId { get; set; }

    public string? IntgId { get; set; }

    public bool IsTrackable { get; set; }

    public virtual ICollection<AlarmActiveAsset> AlarmActiveAssets { get; set; } = new List<AlarmActiveAsset>();

    public virtual ICollection<AlarmPassiveAsset> AlarmPassiveAssets { get; set; } = new List<AlarmPassiveAsset>();

    public virtual ICollection<AssetForm> AssetFormNewEmployees { get; set; } = new List<AssetForm>();

    public virtual ICollection<AssetForm> AssetFormOldEmployees { get; set; } = new List<AssetForm>();

    public virtual ICollection<AssetMaintenanceForm> AssetMaintenanceForms { get; set; } = new List<AssetMaintenanceForm>();

    public virtual ICollection<AssetReuseForm> AssetReuseFormCurrentGurdianships { get; set; } = new List<AssetReuseForm>();

    public virtual ICollection<AssetReuseForm> AssetReuseFormRequestOrigineEmployees { get; set; } = new List<AssetReuseForm>();

    public virtual EmployeeDeparment Department { get; set; } = null!;

    public virtual ICollection<EmployeeSign> EmployeeSigns { get; set; } = new List<EmployeeSign>();

    public virtual ICollection<EmployeeTag> EmployeeTags { get; set; } = new List<EmployeeTag>();

    public virtual ICollection<EmployeeTrackingLog> EmployeeTrackingLogs { get; set; } = new List<EmployeeTrackingLog>();

    public virtual ICollection<EmployeeTracking> EmployeeTrackings { get; set; } = new List<EmployeeTracking>();

    public virtual ICollection<TempProcessGuardenItem> TempProcessGuardenItems { get; set; } = new List<TempProcessGuardenItem>();

    public virtual ICollection<TempProcessMaintenanceItem> TempProcessMaintenanceItems { get; set; } = new List<TempProcessMaintenanceItem>();

    public virtual ICollection<TempProcessTransferItem> TempProcessTransferItems { get; set; } = new List<TempProcessTransferItem>();

    public virtual SystemTransaction Transaction { get; set; } = null!;

    public virtual ICollection<WarehouseExportForm> WarehouseExportFormRecipiantEmployees { get; set; } = new List<WarehouseExportForm>();

    public virtual ICollection<WarehouseExportForm> WarehouseExportFormRequestManagers { get; set; } = new List<WarehouseExportForm>();

    public virtual ICollection<WarehouseForm> WarehouseFormWarehouseManagers { get; set; } = new List<WarehouseForm>();

    public virtual ICollection<WarehouseForm> WarehouseFormWarehousesSheriffs { get; set; } = new List<WarehouseForm>();

    public virtual ICollection<WarehouseImportForm> WarehouseImportForms { get; set; } = new List<WarehouseImportForm>();

    public virtual ICollection<WarehouseManager> WarehouseManagerWarehouseManagerNavigations { get; set; } = new List<WarehouseManager>();

    public virtual ICollection<WarehouseManager> WarehouseManagerWarehousesSheriffs { get; set; } = new List<WarehouseManager>();
}
