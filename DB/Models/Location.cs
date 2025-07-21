using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Location
{
    public int LocationId { get; set; }

    public int? ParentLocationId { get; set; }

    public string LocationName { get; set; } = null!;

    public string? LocationNameEn { get; set; }

    public int LocationTypeId { get; set; }

    public string? LocationCode { get; set; }

    public string? LevelNodeCode { get; set; }

    public string? LocationParentPath { get; set; }

    public string? AreaId { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public bool IsDeleted { get; set; }

    public int? RefId { get; set; }

    public string? RefCode { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual ICollection<Alarm> Alarms { get; set; } = new List<Alarm>();

    public virtual ICollection<AssetFormAuditSession> AssetFormAuditSessions { get; set; } = new List<AssetFormAuditSession>();

    public virtual ICollection<AssetFormItemDistribute> AssetFormItemDistributes { get; set; } = new List<AssetFormItemDistribute>();

    public virtual ICollection<AssetFormMaintenanceItem> AssetFormMaintenanceItems { get; set; } = new List<AssetFormMaintenanceItem>();

    public virtual ICollection<AssetFormRecievedItem> AssetFormRecievedItemFromLocations { get; set; } = new List<AssetFormRecievedItem>();

    public virtual ICollection<AssetFormRecievedItem> AssetFormRecievedItemToLocations { get; set; } = new List<AssetFormRecievedItem>();

    public virtual ICollection<AssetFormSaleReturn> AssetFormSaleReturns { get; set; } = new List<AssetFormSaleReturn>();

    public virtual ICollection<AssetFormSale> AssetFormSales { get; set; } = new List<AssetFormSale>();

    public virtual ICollection<AssetFormTransferItem> AssetFormTransferItemFromLocations { get; set; } = new List<AssetFormTransferItem>();

    public virtual ICollection<AssetFormTransferItem> AssetFormTransferItemToLocations { get; set; } = new List<AssetFormTransferItem>();

    public virtual ICollection<AssetForm> AssetForms { get; set; } = new List<AssetForm>();

    public virtual ICollection<AssetMaintenanceForm> AssetMaintenanceForms { get; set; } = new List<AssetMaintenanceForm>();

    public virtual ICollection<AssetReuseForm> AssetReuseForms { get; set; } = new List<AssetReuseForm>();

    public virtual ICollection<AssetTracking> AssetTrackings { get; set; } = new List<AssetTracking>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogs { get; set; } = new List<AssetTransactionLog>();

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();

    public virtual ICollection<AuditSessionClassResult> AuditSessionClassResults { get; set; } = new List<AuditSessionClassResult>();

    public virtual ICollection<AuditSessionPresentAsset> AuditSessionPresentAssets { get; set; } = new List<AuditSessionPresentAsset>();

    public virtual ICollection<AuditSessionResult> AuditSessionResults { get; set; } = new List<AuditSessionResult>();

    public virtual ICollection<EmployeeDeparment> EmployeeDeparments { get; set; } = new List<EmployeeDeparment>();

    public virtual ICollection<EmployeeTrackingLog> EmployeeTrackingLogs { get; set; } = new List<EmployeeTrackingLog>();

    public virtual ICollection<EmployeeTracking> EmployeeTrackings { get; set; } = new List<EmployeeTracking>();

    public virtual ICollection<ExtraGeofencedAsset> ExtraGeofencedAssets { get; set; } = new List<ExtraGeofencedAsset>();

    public virtual ICollection<Hardware> Hardwares { get; set; } = new List<Hardware>();

    public virtual ICollection<LocationDoor> LocationDoors { get; set; } = new List<LocationDoor>();

    public virtual LocationFin? LocationFin { get; set; }

    public virtual ICollection<LocationTag> LocationTags { get; set; } = new List<LocationTag>();

    public virtual LtlocationType LocationType { get; set; } = null!;

    public virtual ICollection<MissingGeofencedAsset> MissingGeofencedAssets { get; set; } = new List<MissingGeofencedAsset>();

    public virtual ICollection<Rfidantenna> Rfidantennas { get; set; } = new List<Rfidantenna>();

    public virtual ICollection<RfidroomLocator> RfidroomLocators { get; set; } = new List<RfidroomLocator>();

    public virtual ICollection<SirenLocation> SirenLocations { get; set; } = new List<SirenLocation>();

    public virtual ICollection<Siren> Sirens { get; set; } = new List<Siren>();

    public virtual ICollection<Switch> Switches { get; set; } = new List<Switch>();

    public virtual ICollection<SystemApp> SystemApps { get; set; } = new List<SystemApp>();

    public virtual ICollection<TempProcessRegeofencingItem> TempProcessRegeofencingItems { get; set; } = new List<TempProcessRegeofencingItem>();

    public virtual ICollection<TempProcessRegistrationItemLog> TempProcessRegistrationItemLogs { get; set; } = new List<TempProcessRegistrationItemLog>();

    public virtual ICollection<TempProcessRegistrationItem> TempProcessRegistrationItems { get; set; } = new List<TempProcessRegistrationItem>();

    public virtual ICollection<TempProcessReturnItem> TempProcessReturnItems { get; set; } = new List<TempProcessReturnItem>();

    public virtual ICollection<TempProcessTransferItem> TempProcessTransferItems { get; set; } = new List<TempProcessTransferItem>();

    public virtual SystemTransaction? UpdateTransaction { get; set; }

    public virtual ICollection<UserAccessLocation> UserAccessLocations { get; set; } = new List<UserAccessLocation>();

    public virtual ICollection<UserProfileFavLocation> UserProfileFavLocations { get; set; } = new List<UserProfileFavLocation>();

    public virtual ICollection<WarehousReturnFormItem> WarehousReturnFormItems { get; set; } = new List<WarehousReturnFormItem>();

    public virtual ICollection<WarehouseExportForm> WarehouseExportForms { get; set; } = new List<WarehouseExportForm>();

    public virtual ICollection<WarehouseForm> WarehouseForms { get; set; } = new List<WarehouseForm>();

    public virtual WarehouseManager? WarehouseManager { get; set; }

    public virtual ICollection<ZoneLocation> ZoneLocations { get; set; } = new List<ZoneLocation>();

    public virtual ICollection<SecurityGuard> Guards { get; set; } = new List<SecurityGuard>();
}
