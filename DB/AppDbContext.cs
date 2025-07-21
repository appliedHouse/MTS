using Microsoft.EntityFrameworkCore;
using DB.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;


namespace DB;

public class AppDbContext : IdentityDbContext<AppIdentityUser>
{
    int Counter = 0;
    string ConnectionString;

    public AppDbContext() { }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        var optionList = options.Extensions.ToList();
        var option1 = (SqlServerOptionsExtension)optionList[1];
        ConnectionString = option1.ConnectionString ?? "";

        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Counter++;

        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        
    }

    #region public virtual DBSet<T>
    public virtual DbSet<Alarm> Alarms { get; set; }

    public virtual DbSet<AlarmActiveAsset> AlarmActiveAssets { get; set; }

    public virtual DbSet<AlarmHardware> AlarmHardwares { get; set; }

    public virtual DbSet<AlarmPassiveAsset> AlarmPassiveAssets { get; set; }

    public virtual DbSet<Asset> Assets { get; set; }

    public virtual DbSet<AssetAlarmRole> AssetAlarmRoles { get; set; }

    public virtual DbSet<AssetAlarmRoleLog> AssetAlarmRoleLogs { get; set; }

    public virtual DbSet<AssetAssetClass> AssetAssetClasses { get; set; }

    public virtual DbSet<AssetAttachment> AssetAttachments { get; set; }

    public virtual DbSet<AssetDepreciation> AssetDepreciations { get; set; }

    public virtual DbSet<AssetForm> AssetForms { get; set; }

    public virtual DbSet<AssetFormAddTagItem> AssetFormAddTagItems { get; set; }

    public virtual DbSet<AssetFormAlarmRoleItem> AssetFormAlarmRoleItems { get; set; }

    public virtual DbSet<AssetFormAuditSession> AssetFormAuditSessions { get; set; }

    public virtual DbSet<AssetFormAuditSessionLog> AssetFormAuditSessionLogs { get; set; }

    public virtual DbSet<AssetFormBoxTransaction> AssetFormBoxTransactions { get; set; }

    public virtual DbSet<AssetFormBoxTransactionItem> AssetFormBoxTransactionItems { get; set; }

    public virtual DbSet<AssetFormEditAssetItem> AssetFormEditAssetItems { get; set; }

    public virtual DbSet<AssetFormEditTag> AssetFormEditTags { get; set; }

    public virtual DbSet<AssetFormEndLife> AssetFormEndLives { get; set; }

    public virtual DbSet<AssetFormEndLifeItem> AssetFormEndLifeItems { get; set; }

    public virtual DbSet<AssetFormGurdianshipItem> AssetFormGurdianshipItems { get; set; }

    public virtual DbSet<AssetFormItemDistribute> AssetFormItemDistributes { get; set; }

    public virtual DbSet<AssetFormLog> AssetFormLogs { get; set; }

    public virtual DbSet<AssetFormMaintenanceItem> AssetFormMaintenanceItems { get; set; }

    public virtual DbSet<AssetFormRecievedItem> AssetFormRecievedItems { get; set; }

    public virtual DbSet<AssetFormRegistrationItem> AssetFormRegistrationItems { get; set; }

    public virtual DbSet<AssetFormReturnRecieverItem> AssetFormReturnRecieverItems { get; set; }

    public virtual DbSet<AssetFormSale> AssetFormSales { get; set; }

    public virtual DbSet<AssetFormSaleFin> AssetFormSaleFins { get; set; }

    public virtual DbSet<AssetFormSaleIncomItem> AssetFormSaleIncomItems { get; set; }

    public virtual DbSet<AssetFormSaleItem> AssetFormSaleItems { get; set; }

    public virtual DbSet<AssetFormSaleReturn> AssetFormSaleReturns { get; set; }

    public virtual DbSet<AssetFormSaleReturnItem> AssetFormSaleReturnItems { get; set; }

    public virtual DbSet<AssetFormTransferItem> AssetFormTransferItems { get; set; }

    public virtual DbSet<AssetFormUserScheule> AssetFormUserScheules { get; set; }

    public virtual DbSet<AssetMaintenanceForm> AssetMaintenanceForms { get; set; }

    public virtual DbSet<AssetMaintenancePlan> AssetMaintenancePlans { get; set; }

    public virtual DbSet<AssetPrice> AssetPrices { get; set; }

    public virtual DbSet<AssetReuseForm> AssetReuseForms { get; set; }

    public virtual DbSet<AssetReuseFormDetail> AssetReuseFormDetails { get; set; }

    public virtual DbSet<AssetTag> AssetTags { get; set; }

    public virtual DbSet<AssetTagTransactionLog> AssetTagTransactionLogs { get; set; }

    public virtual DbSet<AssetTracking> AssetTrackings { get; set; }

    public virtual DbSet<AssetTransactionLog> AssetTransactionLogs { get; set; }

    public virtual DbSet<AssetWarehouse> AssetWarehouses { get; set; }

    public virtual DbSet<AssetsAndTag> AssetsAndTags { get; set; }

    public virtual DbSet<AssetsClassProfile> AssetsClassProfiles { get; set; }

    public virtual DbSet<AssetsClassProfileLog> AssetsClassProfileLogs { get; set; }

    public virtual DbSet<AssetsClassfication> AssetsClassfications { get; set; }

    public virtual DbSet<AssetsClassficationsLevel> AssetsClassficationsLevels { get; set; }

    public virtual DbSet<AuditSessionClassResult> AuditSessionClassResults { get; set; }

    public virtual DbSet<AuditSessionPresentAsset> AuditSessionPresentAssets { get; set; }

    public virtual DbSet<AuditSessionResult> AuditSessionResults { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<CfvTag> CfvTags { get; set; }

    public virtual DbSet<ClildernClassfication> ClildernClassfications { get; set; }

    public virtual DbSet<CountCustomValue> CountCustomValues { get; set; }

    public virtual DbSet<CustomFieldsDefinition> CustomFieldsDefinitions { get; set; }

    public virtual DbSet<CustomFieldsOption> CustomFieldsOptions { get; set; }

    public virtual DbSet<CustomFieldsValue> CustomFieldsValues { get; set; }

    public virtual DbSet<DeprceationDataView> DeprceationDataViews { get; set; }

    public virtual DbSet<DepreciationPlan> DepreciationPlans { get; set; }

    public virtual DbSet<EmailLog> EmailLogs { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeDeparment> EmployeeDeparments { get; set; }

    public virtual DbSet<EmployeeSign> EmployeeSigns { get; set; }

    public virtual DbSet<EmployeeTag> EmployeeTags { get; set; }

    public virtual DbSet<EmployeeTracking> EmployeeTrackings { get; set; }

    public virtual DbSet<EmployeeTrackingLog> EmployeeTrackingLogs { get; set; }

    public virtual DbSet<ExtraGeofencedAsset> ExtraGeofencedAssets { get; set; }

    public virtual DbSet<FormSign> FormSigns { get; set; }

    public virtual DbSet<GetGuardianShip> GetGuardianShips { get; set; }

    public virtual DbSet<GroupPrivilege> GroupPrivileges { get; set; }

    public virtual DbSet<Hardware> Hardwares { get; set; }

    public virtual DbSet<HardwareConnectionLog> HardwareConnectionLogs { get; set; }

    public virtual DbSet<IsPrivate> IsPrivates { get; set; }

    public virtual DbSet<IsPrivateCfvtag> IsPrivateCfvtags { get; set; }

    public virtual DbSet<LastMonthProcessReportView> LastMonthProcessReportViews { get; set; }

    public virtual DbSet<License> Licenses { get; set; }

    public virtual DbSet<LiteService> LiteServices { get; set; }

    public virtual DbSet<LiteUserService> LiteUserServices { get; set; }

    public virtual DbSet<LocalizationString> LocalizationStrings { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<LocationArea> LocationAreas { get; set; }

    public virtual DbSet<LocationDoor> LocationDoors { get; set; }

    public virtual DbSet<LocationDoorArmingTime> LocationDoorArmingTimes { get; set; }

    public virtual DbSet<LocationFin> LocationFins { get; set; }

    public virtual DbSet<LocationTag> LocationTags { get; set; }

    public virtual DbSet<LtalarmCloseReason> LtalarmCloseReasons { get; set; }

    public virtual DbSet<LtalarmNotificationType> LtalarmNotificationTypes { get; set; }

    public virtual DbSet<LtalarmStatus> LtalarmStatuses { get; set; }

    public virtual DbSet<LtalarmType> LtalarmTypes { get; set; }

    public virtual DbSet<LtantennaFunction> LtantennaFunctions { get; set; }

    public virtual DbSet<LtassetForm> LtassetForms { get; set; }

    public virtual DbSet<LtassetFormSaleType> LtassetFormSaleTypes { get; set; }

    public virtual DbSet<LtassetMaintenanceStatus> LtassetMaintenanceStatuses { get; set; }

    public virtual DbSet<LtassetState> LtassetStates { get; set; }

    public virtual DbSet<LtassetTransferReason> LtassetTransferReasons { get; set; }

    public virtual DbSet<LtassetType> LtassetTypes { get; set; }

    public virtual DbSet<LtassetUnit> LtassetUnits { get; set; }

    public virtual DbSet<LtauditSessionStatus> LtauditSessionStatuses { get; set; }

    public virtual DbSet<LtauditSessionType> LtauditSessionTypes { get; set; }

    public virtual DbSet<LtbackupType> LtbackupTypes { get; set; }

    public virtual DbSet<LtboxTransactionType> LtboxTransactionTypes { get; set; }

    public virtual DbSet<LtcameraType> LtcameraTypes { get; set; }

    public virtual DbSet<Ltcolor> Ltcolors { get; set; }

    public virtual DbSet<LtcontainerMode> LtcontainerModes { get; set; }

    public virtual DbSet<LtcreatorType> LtcreatorTypes { get; set; }

    public virtual DbSet<LtcustomFieldsType> LtcustomFieldsTypes { get; set; }

    public virtual DbSet<LtdayName> LtdayNames { get; set; }

    public virtual DbSet<LtdestructionType> LtdestructionTypes { get; set; }

    public virtual DbSet<LtformProcessState> LtformProcessStates { get; set; }

    public virtual DbSet<LtformType> LtformTypes { get; set; }

    public virtual DbSet<LthardwareConnectionState> LthardwareConnectionStates { get; set; }

    public virtual DbSet<LthardwareModel> LthardwareModels { get; set; }

    public virtual DbSet<LthardwareType> LthardwareTypes { get; set; }

    public virtual DbSet<Ltlanguage> Ltlanguages { get; set; }

    public virtual DbSet<LtlocationType> LtlocationTypes { get; set; }

    public virtual DbSet<LtmaintenanceType> LtmaintenanceTypes { get; set; }

    public virtual DbSet<LtpassiveReaderSearchMode> LtpassiveReaderSearchModes { get; set; }

    public virtual DbSet<LtpaymentMethod> LtpaymentMethods { get; set; }

    public virtual DbSet<Ltperioritie> Ltperiorities { get; set; }

    public virtual DbSet<LtprocessState> LtprocessStates { get; set; }

    public virtual DbSet<LtprocessType> LtprocessTypes { get; set; }

    public virtual DbSet<LtprocessUserAction> LtprocessUserActions { get; set; }

    public virtual DbSet<LtreaderFunction> LtreaderFunctions { get; set; }

    public virtual DbSet<LtrelayPort> LtrelayPorts { get; set; }

    public virtual DbSet<LtrfidtagType> LtrfidtagTypes { get; set; }

    public virtual DbSet<LtsaleCancelReason> LtsaleCancelReasons { get; set; }

    public virtual DbSet<LtsystemAppType> LtsystemAppTypes { get; set; }

    public virtual DbSet<LtsystemEntity> LtsystemEntities { get; set; }

    public virtual DbSet<MissingAsset> MissingAssets { get; set; }

    public virtual DbSet<MissingGeofencedAsset> MissingGeofencedAssets { get; set; }

    public virtual DbSet<ParpareDepreciationView> ParpareDepreciationViews { get; set; }

    public virtual DbSet<PendingAssetRegistrationForm> PendingAssetRegistrationForms { get; set; }

    public virtual DbSet<PredefindTag> PredefindTags { get; set; }

    public virtual DbSet<ProcessedAssetForm> ProcessedAssetForms { get; set; }

    public virtual DbSet<ProcessedAssetFormLog> ProcessedAssetFormLogs { get; set; }

    public virtual DbSet<ReportInfo> ReportInfos { get; set; }

    public virtual DbSet<RfidactiveReader> RfidactiveReaders { get; set; }

    public virtual DbSet<Rfidantenna> Rfidantennas { get; set; }

    public virtual DbSet<Rfidcamera> Rfidcameras { get; set; }

    public virtual DbSet<RfidhandHeld> RfidhandHelds { get; set; }

    public virtual DbSet<RfidpassiveReader> RfidpassiveReaders { get; set; }

    public virtual DbSet<RfidroomLocator> RfidroomLocators { get; set; }

    public virtual DbSet<Rfidscreen> Rfidscreens { get; set; }

    public virtual DbSet<SecurityGuard> SecurityGuards { get; set; }

    public virtual DbSet<ServiceFunction> ServiceFunctions { get; set; }

    public virtual DbSet<Siren> Sirens { get; set; }

    public virtual DbSet<SirenLocation> SirenLocations { get; set; }

    public virtual DbSet<SirenReader> SirenReaders { get; set; }

    public virtual DbSet<SirenRelay> SirenRelays { get; set; }

    public virtual DbSet<SirenRole> SirenRoles { get; set; }

    public virtual DbSet<Smslog> Smslogs { get; set; }

    public virtual DbSet<Switch> Switches { get; set; }

    public virtual DbSet<SystemAlarmRole> SystemAlarmRoles { get; set; }

    public virtual DbSet<SystemApp> SystemApps { get; set; }

    public virtual DbSet<SystemAssetStateRule> SystemAssetStateRules { get; set; }

    public virtual DbSet<SystemBugsLog> SystemBugsLogs { get; set; }

    public virtual DbSet<SystemConfig> SystemConfigs { get; set; }

    public virtual DbSet<SystemCore> SystemCores { get; set; }

    public virtual DbSet<SystemCoreTransaction> SystemCoreTransactions { get; set; }

    public virtual DbSet<SystemService> SystemServices { get; set; }

    public virtual DbSet<SystemSetting> SystemSettings { get; set; }

    public virtual DbSet<SystemTagFilter> SystemTagFilters { get; set; }

    public virtual DbSet<SystemTransaction> SystemTransactions { get; set; }

    public virtual DbSet<TaskRole> TaskRoles { get; set; }

    public virtual DbSet<TaskRoleProcess> TaskRoleProcesses { get; set; }

    public virtual DbSet<Temp2> Temp2s { get; set; }

    public virtual DbSet<Temp3> Temp3s { get; set; }

    public virtual DbSet<Temp4> Temp4s { get; set; }

    public virtual DbSet<Temp5> Temp5s { get; set; }

    public virtual DbSet<Temp6> Temp6s { get; set; }

    public virtual DbSet<TempAssetEditTag> TempAssetEditTags { get; set; }

    public virtual DbSet<TempAssetTag> TempAssetTags { get; set; }

    public virtual DbSet<TempDatum> TempData { get; set; }

    public virtual DbSet<TempProcess> TempProcesses { get; set; }

    public virtual DbSet<TempProcessCustomFieldDatum> TempProcessCustomFieldData { get; set; }

    public virtual DbSet<TempProcessEditItem> TempProcessEditItems { get; set; }

    public virtual DbSet<TempProcessGuardenItem> TempProcessGuardenItems { get; set; }

    public virtual DbSet<TempProcessLog> TempProcessLogs { get; set; }

    public virtual DbSet<TempProcessMaintenanceItem> TempProcessMaintenanceItems { get; set; }

    public virtual DbSet<TempProcessRegeofencingItem> TempProcessRegeofencingItems { get; set; }

    public virtual DbSet<TempProcessRegistrationItem> TempProcessRegistrationItems { get; set; }

    public virtual DbSet<TempProcessRegistrationItemLog> TempProcessRegistrationItemLogs { get; set; }

    public virtual DbSet<TempProcessReturnItem> TempProcessReturnItems { get; set; }

    public virtual DbSet<TempProcessTransferItem> TempProcessTransferItems { get; set; }

    public virtual DbSet<TicketVideoRecoding> TicketVideoRecodings { get; set; }

    public virtual DbSet<UnusedDataBackupConfig> UnusedDataBackupConfigs { get; set; }

    public virtual DbSet<UserAccessLocation> UserAccessLocations { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    public virtual DbSet<UserAlarm> UserAlarms { get; set; }

    public virtual DbSet<UserAssetReport> UserAssetReports { get; set; }

    public virtual DbSet<UserGroup> UserGroups { get; set; }

    public virtual DbSet<UserLoginLog> UserLoginLogs { get; set; }

    public virtual DbSet<UserProcessType> UserProcessTypes { get; set; }

    public virtual DbSet<UserProfileFavClass> UserProfileFavClasses { get; set; }

    public virtual DbSet<UserProfileFavLocation> UserProfileFavLocations { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserScheduleI> UserScheduleIs { get; set; }

    public virtual DbSet<UserScheduleIlog> UserScheduleIlogs { get; set; }

    public virtual DbSet<UserTask> UserTasks { get; set; }

    public virtual DbSet<UserTaskAction> UserTaskActions { get; set; }

    public virtual DbSet<UserTaskActionLog> UserTaskActionLogs { get; set; }

    public virtual DbSet<UserTaskRole> UserTaskRoles { get; set; }

    public virtual DbSet<VClass8> VClass8s { get; set; }

    public virtual DbSet<ViewAssetRule> ViewAssetRules { get; set; }

    public virtual DbSet<ViewJeddah> ViewJeddahs { get; set; }

    public virtual DbSet<ViewRiyadh> ViewRiyadhs { get; set; }

    public virtual DbSet<WarehousReturnFormItem> WarehousReturnFormItems { get; set; }

    public virtual DbSet<WarehouseExportForm> WarehouseExportForms { get; set; }

    public virtual DbSet<WarehouseExportFormItem> WarehouseExportFormItems { get; set; }

    public virtual DbSet<WarehouseForm> WarehouseForms { get; set; }

    public virtual DbSet<WarehouseImportForm> WarehouseImportForms { get; set; }

    public virtual DbSet<WarehouseImportFormItem> WarehouseImportFormItems { get; set; }

    public virtual DbSet<WarehouseManager> WarehouseManagers { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

    public virtual DbSet<ZoneLocation> ZoneLocations { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var entity in modelBuilder.Model.GetEntityTypes())
        {
            // Set table name to match entity class name exactly (preserve casing)
            entity.SetTableName(entity.ClrType.Name);
        }

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<AppIdentityUser>().ToTable("UserAccounts");

        modelBuilder.UseCollation("Arabic_CI_AS");

        modelBuilder.Entity<Alarm>(entity =>
        {
            entity.ToTable("Alarm");

            entity.Property(e => e.AlarmId)
                .ValueGeneratedNever()
                .HasColumnName("AlarmID");
            entity.Property(e => e.CloseDate).HasColumnType("datetime");
            entity.Property(e => e.CloseReasonId).HasColumnName("CloseReasonID");
            entity.Property(e => e.CreatorTypeId)
                .HasComment("the entity type of alarm, ex: hardware PAssive Asset or Active Asset")
                .HasColumnName("CreatorTypeID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.OpenDate).HasColumnType("datetime");
            entity.Property(e => e.OwnerUserId).HasColumnName("OwnerUserID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

            entity.HasOne(d => d.CloseReason).WithMany(p => p.Alarms)
                .HasForeignKey(d => d.CloseReasonId)
                .HasConstraintName("FK_Tickets_LTTicketCloseReasons");

            entity.HasOne(d => d.ClosedByUserNavigation).WithMany(p => p.AlarmClosedByUserNavigations)
                .HasForeignKey(d => d.ClosedByUser)
                .HasConstraintName("FK_Tickets_Users");

            entity.HasOne(d => d.CreatorType).WithMany(p => p.Alarms)
                .HasForeignKey(d => d.CreatorTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Alarm_LTCreatorType");

            entity.HasOne(d => d.Location).WithMany(p => p.Alarms)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Alarm_Location");

            entity.HasOne(d => d.OwnerUser).WithMany(p => p.AlarmOwnerUsers)
                .HasForeignKey(d => d.OwnerUserId)
                .HasConstraintName("FK_Alarm_UserAccount");

            entity.HasOne(d => d.Status).WithMany(p => p.Alarms)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Alarm_LTAlarmStatus");

            entity.HasOne(d => d.Type).WithMany(p => p.Alarms)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tickets_LTTicketTypes");

            entity.HasOne(d => d.Zone).WithMany(p => p.Alarms)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("FK_Alarm_Zone");
        });

        modelBuilder.Entity<AlarmActiveAsset>(entity =>
        {
            entity.HasKey(e => e.AlarmId);

            entity.ToTable("AlarmActiveAsset");

            entity.Property(e => e.AlarmId)
                .ValueGeneratedNever()
                .HasColumnName("AlarmID");
            entity.Property(e => e.AntennaASsi).HasColumnName("Antenna_A_SSI");
            entity.Property(e => e.AntennaBSsi).HasColumnName("Antenna_B_SSI");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.GurdianshipId).HasColumnName("GurdianshipID");
            entity.Property(e => e.ReaderId).HasColumnName("ReaderID");
            entity.Property(e => e.ReadingAntennaName).HasMaxLength(50);
            entity.Property(e => e.ReadingSsi).HasColumnName("ReadingSSI");
            entity.Property(e => e.RoomLocatorId).HasColumnName("RoomLocatorID");
            entity.Property(e => e.TagId)
                .HasMaxLength(50)
                .HasColumnName("TagID");
            entity.Property(e => e.Xposition).HasColumnName("XPosition");
            entity.Property(e => e.Yposition).HasColumnName("YPosition");

            entity.HasOne(d => d.Alarm).WithOne(p => p.AlarmActiveAsset)
                .HasForeignKey<AlarmActiveAsset>(d => d.AlarmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlarmActiveAsset_Alarm");

            entity.HasOne(d => d.Asset).WithMany(p => p.AlarmActiveAssets)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlarmAsset_Assets");

            entity.HasOne(d => d.Gurdianship).WithMany(p => p.AlarmActiveAssets)
                .HasForeignKey(d => d.GurdianshipId)
                .HasConstraintName("FK_AlarmAsset_Employee");

            entity.HasOne(d => d.Reader).WithMany(p => p.AlarmActiveAssets)
                .HasForeignKey(d => d.ReaderId)
                .HasConstraintName("FK_AlarmActiveAsset_Hardware");

            entity.HasOne(d => d.ReaderNavigation).WithMany(p => p.AlarmActiveAssets)
                .HasForeignKey(d => d.ReaderId)
                .HasConstraintName("FK_AlarmAsset_Hardware");

            entity.HasOne(d => d.RoomLocator).WithMany(p => p.AlarmActiveAssets)
                .HasForeignKey(d => d.RoomLocatorId)
                .HasConstraintName("FK_AlarmAsset_RFIDRoomLocator");
        });

        modelBuilder.Entity<AlarmHardware>(entity =>
        {
            entity.HasKey(e => e.AlarmId);

            entity.ToTable("AlarmHardware");

            entity.Property(e => e.AlarmId)
                .ValueGeneratedNever()
                .HasColumnName("AlarmID");
            entity.Property(e => e.HardwareId).HasColumnName("HardwareID");

            entity.HasOne(d => d.Alarm).WithOne(p => p.AlarmHardware)
                .HasForeignKey<AlarmHardware>(d => d.AlarmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlarmHardware_Alarm");

            entity.HasOne(d => d.Hardware).WithMany(p => p.AlarmHardwares)
                .HasForeignKey(d => d.HardwareId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlarmHardware_Hardware");
        });

        modelBuilder.Entity<AlarmPassiveAsset>(entity =>
        {
            entity.HasKey(e => e.AlarmId).HasName("PK_AlarmPassiveAsset_1");

            entity.ToTable("AlarmPassiveAsset");

            entity.Property(e => e.AlarmId)
                .ValueGeneratedNever()
                .HasColumnName("AlarmID");
            entity.Property(e => e.AntennaId).HasColumnName("AntennaID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.GurdianshipId).HasColumnName("GurdianshipID");
            entity.Property(e => e.ReaderId).HasColumnName("ReaderID");
            entity.Property(e => e.ReadingSsi).HasColumnName("ReadingSSI");
            entity.Property(e => e.TagId)
                .HasMaxLength(50)
                .HasColumnName("TagID");
            entity.Property(e => e.Xposition).HasColumnName("XPosition");
            entity.Property(e => e.Yposition).HasColumnName("YPosition");

            entity.HasOne(d => d.Alarm).WithOne(p => p.AlarmPassiveAsset)
                .HasForeignKey<AlarmPassiveAsset>(d => d.AlarmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlarmPassiveAsset_Alarm");

            entity.HasOne(d => d.Antenna).WithMany(p => p.AlarmPassiveAssets)
                .HasForeignKey(d => d.AntennaId)
                .HasConstraintName("FK_AlarmPassiveAsset_RFIDAntenna");

            entity.HasOne(d => d.Asset).WithMany(p => p.AlarmPassiveAssets)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlarmPassiveAsset_Assets");

            entity.HasOne(d => d.Gurdianship).WithMany(p => p.AlarmPassiveAssets)
                .HasForeignKey(d => d.GurdianshipId)
                .HasConstraintName("FK_AlarmPassiveAsset_Employee");

            entity.HasOne(d => d.Reader).WithMany(p => p.AlarmPassiveAssets)
                .HasForeignKey(d => d.ReaderId)
                .HasConstraintName("FK_AlarmPassiveAsset_Hardware");

            entity.HasOne(d => d.ReaderNavigation).WithMany(p => p.AlarmPassiveAssets)
                .HasForeignKey(d => d.ReaderId)
                .HasConstraintName("FK_AlarmPassiveAsset_RFIDPassiveReader");
        });

        modelBuilder.Entity<Asset>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("updateAssetLastUpdateDate"));

            entity.HasIndex(e => e.IsPendingState, "_dta_index_Assets_31_1095010982__K21");

            entity.HasIndex(e => new { e.AssetStateId, e.AssetClassId, e.AssetId, e.LocationId }, "_dta_index_Assets_7_1095010982__K11_K2_K1_K13");

            entity.HasIndex(e => e.LocationId, "_dta_index_Assets_7_1095010982__K13");

            entity.HasIndex(e => e.LocationId, "_dta_index_Assets_7_1095010982__K13_2_26");

            entity.HasIndex(e => new { e.LocationId, e.AssetId }, "_dta_index_Assets_7_1095010982__K13_K1");

            entity.HasIndex(e => new { e.LocationId, e.AssetClassId, e.AssetId, e.AssetStateId }, "_dta_index_Assets_7_1095010982__K13_K2_K1_K11");

            entity.HasIndex(e => new { e.IsRemoved, e.GurdianShipFormId, e.AssetId, e.LocationId, e.IsPendingState, e.IsContainer, e.IsDepreciable, e.IsTrackable, e.IsInMaintenance, e.AssetStateId }, "_dta_index_Assets_7_1095010982__K19_K14_K1_K13_K21_K16_K20_K18_K17_K11_26");

            entity.HasIndex(e => e.AssetId, "_dta_index_Assets_7_1095010982__K1_26");

            entity.HasIndex(e => e.AssetClassId, "_dta_index_Assets_7_1095010982__K2");

            entity.HasIndex(e => e.AssetClassId, "_dta_index_Assets_7_1095010982__K2_3");

            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");
            entity.Property(e => e.AssetStateId).HasColumnName("AssetStateID");
            entity.Property(e => e.AssetWeightUnit).HasDefaultValue(2);
            entity.Property(e => e.ColorId).HasColumnName("ColorID");
            entity.Property(e => e.Gpslocation)
                .HasMaxLength(50)
                .HasColumnName("GPSLocation");
            entity.Property(e => e.GurdianShipFormId).HasColumnName("GurdianShipFormID");
            entity.Property(e => e.IsDepreciable).HasDefaultValue(true);
            entity.Property(e => e.IsRecieved).HasDefaultValue(true);
            entity.Property(e => e.IsTrackable).HasDefaultValue(true);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MaintancePlanId).HasColumnName("MaintancePlanID");
            entity.Property(e => e.MaintenanceStatusId)
                .HasDefaultValue(1)
                .HasColumnName("MaintenanceStatusID");
            entity.Property(e => e.ManufactureSn).HasColumnName("ManufactureSN");
            entity.Property(e => e.PendingProcessedFormId).HasColumnName("PendingProcessedFormID");
            entity.Property(e => e.Quantity).HasDefaultValue(1.0);
            entity.Property(e => e.RealtedAssetId).HasColumnName("RealtedAssetID");
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            entity.Property(e => e.SaveAssetDate).HasColumnType("datetime");
            entity.Property(e => e.StartMaintancePlanDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.AssetAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assets_SystemTransaction_Add");

            entity.HasOne(d => d.AssetClass).WithMany(p => p.Assets)
                .HasForeignKey(d => d.AssetClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assets_AssetsClassfications");

            entity.HasOne(d => d.AssetState).WithMany(p => p.Assets)
                .HasForeignKey(d => d.AssetStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assets_LTAssetStates");

            entity.HasOne(d => d.AssetUnitNavigation).WithMany(p => p.AssetAssetUnitNavigations)
                .HasForeignKey(d => d.AssetUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assets_LTAssetUnit");

            entity.HasOne(d => d.AssetWeightUnitNavigation).WithMany(p => p.AssetAssetWeightUnitNavigations)
                .HasForeignKey(d => d.AssetWeightUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assets_LTAssetUnit_Weight");

            entity.HasOne(d => d.Color).WithMany(p => p.Assets)
                .HasForeignKey(d => d.ColorId)
                .HasConstraintName("FK_Assets_LTColor");

            entity.HasOne(d => d.GurdianShipForm).WithMany(p => p.AssetGurdianShipForms)
                .HasForeignKey(d => d.GurdianShipFormId)
                .HasConstraintName("FK_Assets_GurdianshipForm");

            entity.HasOne(d => d.Location).WithMany(p => p.Assets)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assets_Location");

            entity.HasOne(d => d.MaintancePlan).WithMany(p => p.Assets)
                .HasForeignKey(d => d.MaintancePlanId)
                .HasConstraintName("FK_Assets_AssetMaintenancePlan");

            entity.HasOne(d => d.MaintenanceStatus).WithMany(p => p.Assets)
                .HasForeignKey(d => d.MaintenanceStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assets_LTAssetMaintenanceStatus");

            entity.HasOne(d => d.PendingProcessedForm).WithMany(p => p.AssetPendingProcessedForms)
                .HasForeignKey(d => d.PendingProcessedFormId)
                .HasConstraintName("FK_Assets_PendingAssetForm");

            entity.HasOne(d => d.RealtedAsset).WithMany(p => p.InverseRealtedAsset)
                .HasForeignKey(d => d.RealtedAssetId)
                .HasConstraintName("FK_Assets_Assets");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.AssetUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_Assets_SystemTransaction_Update");
        });

        modelBuilder.Entity<AssetAlarmRole>(entity =>
        {
            entity.HasKey(e => e.AssetId).HasName("PK_AssetRole");

            entity.ToTable("AssetAlarmRole");

            entity.Property(e => e.AssetId)
                .ValueGeneratedNever()
                .HasColumnName("AssetID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.AlarmIfgatePass).HasColumnName("AlarmIFGatePass");
            entity.Property(e => e.AlarmIflost).HasColumnName("AlarmIFLost");
            entity.Property(e => e.AlarmIfmotion).HasColumnName("AlarmIFMotion");
            entity.Property(e => e.AlarmIfnearstReaderChange).HasColumnName("AlarmIFNearstReaderChange");
            entity.Property(e => e.AlarmIfnotDetected).HasColumnName("AlarmIFNotDetected");
            entity.Property(e => e.AlarmIfpanic).HasColumnName("AlarmIFPanic");
            entity.Property(e => e.AlarmIfroomLocatorChange).HasColumnName("AlarmIFRoomLocatorChange");
            entity.Property(e => e.AlarmIftamper).HasColumnName("AlarmIFTamper");
            entity.Property(e => e.AlarmIfunAuthZonePass).HasColumnName("AlarmIFUnAuthZonePass");
            entity.Property(e => e.AlarmIfunCovered).HasColumnName("AlarmIFUnCovered");
            entity.Property(e => e.AlarmIfzoneChange).HasColumnName("AlarmIFZoneChange");
            entity.Property(e => e.AssetFormId).HasColumnName("AssetFormID");
            entity.Property(e => e.GeofencingZoneId).HasColumnName("GeofencingZoneID");
            entity.Property(e => e.RepeatAlarmIfgatePass).HasColumnName("RepeatAlarmIFGatePass");
            entity.Property(e => e.RepeatAlarmIfnearstReaderChange).HasColumnName("RepeatAlarmIFNearstReaderChange");
            entity.Property(e => e.RepeatAlarmIfroomLocatorChange).HasColumnName("RepeatAlarmIFRoomLocatorChange");
            entity.Property(e => e.RepeatAlarmIfunAuthZonePass).HasColumnName("RepeatAlarmIFUnAuthZonePass");
            entity.Property(e => e.RepeatAlarmIfzoneChange).HasColumnName("RepeatAlarmIFZoneChange");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.AssetAlarmRoles)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetRole_AddSystemTransaction");

            entity.HasOne(d => d.AssetForm).WithMany(p => p.AssetAlarmRoles)
                .HasForeignKey(d => d.AssetFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetRole_AssetForm");

            entity.HasOne(d => d.Asset).WithOne(p => p.AssetAlarmRole)
                .HasForeignKey<AssetAlarmRole>(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetRole_Assets");

            entity.HasOne(d => d.GeofencingZone).WithMany(p => p.AssetAlarmRoles)
                .HasForeignKey(d => d.GeofencingZoneId)
                .HasConstraintName("FK_AssetRole_Zone");
        });

        modelBuilder.Entity<AssetAlarmRoleLog>(entity =>
        {
            entity.HasKey(e => e.AssetRoleLogId).HasName("PK_AssetRoleLog");

            entity.ToTable("AssetAlarmRoleLog");

            entity.Property(e => e.AssetRoleLogId).HasColumnName("AssetRoleLogID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.AlarmIfgatePass).HasColumnName("AlarmIFGatePass");
            entity.Property(e => e.AlarmIflost).HasColumnName("AlarmIFLost");
            entity.Property(e => e.AlarmIfmotion).HasColumnName("AlarmIFMotion");
            entity.Property(e => e.AlarmIfnearstReaderChange).HasColumnName("AlarmIFNearstReaderChange");
            entity.Property(e => e.AlarmIfnotDetected).HasColumnName("AlarmIFNotDetected");
            entity.Property(e => e.AlarmIfpanic).HasColumnName("AlarmIFPanic");
            entity.Property(e => e.AlarmIfroomLocatorChange).HasColumnName("AlarmIFRoomLocatorChange");
            entity.Property(e => e.AlarmIftamper).HasColumnName("AlarmIFTamper");
            entity.Property(e => e.AlarmIfunAuthZonePass).HasColumnName("AlarmIFUnAuthZonePass");
            entity.Property(e => e.AlarmIfunCovered).HasColumnName("AlarmIFUnCovered");
            entity.Property(e => e.AlarmIfzoneChange).HasColumnName("AlarmIFZoneChange");
            entity.Property(e => e.AssetFormId).HasColumnName("AssetFormID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.GeofencingZoneId).HasColumnName("GeofencingZoneID");
            entity.Property(e => e.RepeatAlarmIfgatePass).HasColumnName("RepeatAlarmIFGatePass");
            entity.Property(e => e.RepeatAlarmIfnearstReaderChange).HasColumnName("RepeatAlarmIFNearstReaderChange");
            entity.Property(e => e.RepeatAlarmIfroomLocatorChange).HasColumnName("RepeatAlarmIFRoomLocatorChange");
            entity.Property(e => e.RepeatAlarmIfunAuthZonePass).HasColumnName("RepeatAlarmIFUnAuthZonePass");
            entity.Property(e => e.RepeatAlarmIfzoneChange).HasColumnName("RepeatAlarmIFZoneChange");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.AssetAlarmRoleLogs)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetRoleLog_SystemTransaction");

            entity.HasOne(d => d.AssetForm).WithMany(p => p.AssetAlarmRoleLogs)
                .HasForeignKey(d => d.AssetFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetRoleLog_AssetForm");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetAlarmRoleLogs)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetAlarmRoleLog_Assets");
        });

        modelBuilder.Entity<AssetAssetClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Asset_AssetClass");

            entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");
            entity.Property(e => e.AssetId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AssetID");
        });

        modelBuilder.Entity<AssetAttachment>(entity =>
        {
            entity.ToTable("AssetAttachment");

            entity.Property(e => e.AssetAttachmentId).HasColumnName("AssetAttachmentID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AttachmentFileName).HasMaxLength(250);
            entity.Property(e => e.AttachmentFilePath).HasMaxLength(250);
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.AssetAttachmentAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetAttachment_AddSystemTransaction");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetAttachments)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetAttachment_Assets");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.AssetAttachmentUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_AssetAttachment_UpdateSystemTransaction");
        });

        modelBuilder.Entity<AssetDepreciation>(entity =>
        {
            entity.ToTable("AssetDepreciation");

            entity.Property(e => e.AssetDepreciationId).HasColumnName("AssetDepreciationID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.DepreciationPlanId).HasColumnName("DepreciationPlanID");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetDepreciations)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetDepreciation_Assets");

            entity.HasOne(d => d.DepreciationPlan).WithMany(p => p.AssetDepreciations)
                .HasForeignKey(d => d.DepreciationPlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetDepreciation_DepreciationPlan");
        });

        modelBuilder.Entity<AssetForm>(entity =>
        {
            entity.HasKey(e => e.FormId);

            entity.ToTable("AssetForm");

            entity.HasIndex(e => e.FormCode, "IX_AssetFormCode").IsUnique();

            entity.HasIndex(e => new { e.AddTransactionId, e.FormDate }, "_dta_index_AssetForm_31_1125579048__K20_K4");

            entity.HasIndex(e => new { e.FormDate, e.AddTransactionId, e.FormId }, "_dta_index_AssetForm_31_1125579048__K4_K20_K1_2_5_6_7_8_12_18");

            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.FormCode).HasMaxLength(20);
            entity.Property(e => e.FormDate).HasColumnType("datetime");
            entity.Property(e => e.FormProcessReasonId).HasColumnName("FormProcessReasonID");
            entity.Property(e => e.FormProcessStateId).HasColumnName("FormProcessStateID");
            entity.Property(e => e.FormProcessTypeId).HasColumnName("FormProcessTypeID");
            entity.Property(e => e.FormProcessedByUserId).HasColumnName("FormProcessedByUserID");
            entity.Property(e => e.FormRefrenceNo).HasMaxLength(50);
            entity.Property(e => e.FormReportUrl).HasColumnName("FormReportURL");
            entity.Property(e => e.FormSigns).HasMaxLength(50);
            entity.Property(e => e.NewEmployeeDepartmentId).HasColumnName("NewEmployeeDepartmentID");
            entity.Property(e => e.NewEmployeeId).HasColumnName("NewEmployeeID");
            entity.Property(e => e.OldEmployeeDepartmentId).HasColumnName("OldEmployeeDepartmentID");
            entity.Property(e => e.OldEmployeeId).HasColumnName("OldEmployeeID");
            entity.Property(e => e.RequestProcessLocationId).HasColumnName("RequestProcessLocationID");
            entity.Property(e => e.TempProcessId).HasColumnName("TempProcessID");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.AssetFormAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetForm_AddSystemTransaction");

            entity.HasOne(d => d.FormProcessReason).WithMany(p => p.AssetForms)
                .HasForeignKey(d => d.FormProcessReasonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetForm_LTAssetTransferReason");

            entity.HasOne(d => d.FormProcessState).WithMany(p => p.AssetForms)
                .HasForeignKey(d => d.FormProcessStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetForm_LTFormProcessState");

            entity.HasOne(d => d.FormProcessType).WithMany(p => p.AssetForms)
                .HasForeignKey(d => d.FormProcessTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetForm_LTProcessType");

            entity.HasOne(d => d.FormProcessedByUser).WithMany(p => p.AssetForms)
                .HasForeignKey(d => d.FormProcessedByUserId)
                .HasConstraintName("FK_AssetForm_UserAccount");

            entity.HasOne(d => d.NewEmployeeDepartment).WithMany(p => p.AssetFormNewEmployeeDepartments)
                .HasForeignKey(d => d.NewEmployeeDepartmentId)
                .HasConstraintName("FK_AssetForm_NewEmployeeDeparment");

            entity.HasOne(d => d.NewEmployee).WithMany(p => p.AssetFormNewEmployees)
                .HasForeignKey(d => d.NewEmployeeId)
                .HasConstraintName("FK_AssetForm_NewEmployee");

            entity.HasOne(d => d.OldEmployeeDepartment).WithMany(p => p.AssetFormOldEmployeeDepartments)
                .HasForeignKey(d => d.OldEmployeeDepartmentId)
                .HasConstraintName("FK_AssetForm_OldEmployeeDeparment");

            entity.HasOne(d => d.OldEmployee).WithMany(p => p.AssetFormOldEmployees)
                .HasForeignKey(d => d.OldEmployeeId)
                .HasConstraintName("FK_AssetForm_OldEmployee");

            entity.HasOne(d => d.RequestProcessLocation).WithMany(p => p.AssetForms)
                .HasForeignKey(d => d.RequestProcessLocationId)
                .HasConstraintName("FK_AssetForm_Location");

            entity.HasOne(d => d.TempProcess).WithMany(p => p.AssetForms)
                .HasForeignKey(d => d.TempProcessId)
                .HasConstraintName("FK_AssetForm_TempProcess");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.AssetFormUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_AssetForm_UpdateSystemTransaction");
        });

        modelBuilder.Entity<AssetFormAddTagItem>(entity =>
        {
            entity.ToTable("AssetFormAddTagItem");

            entity.Property(e => e.AssetFormAddTagItemId).HasColumnName("AssetFormAddTagItemID");
            entity.Property(e => e.AssetFormId).HasColumnName("AssetFormID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTransactionId).HasColumnName("AssetTransactionID");
            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
        });

        modelBuilder.Entity<AssetFormAlarmRoleItem>(entity =>
        {
            entity.ToTable("AssetFormAlarmRoleItem");

            entity.Property(e => e.AssetFormAlarmRoleItemId).HasColumnName("AssetFormAlarmRoleItemID");
            entity.Property(e => e.AlarmIfgatePass).HasColumnName("AlarmIFGatePass");
            entity.Property(e => e.AlarmIflost).HasColumnName("AlarmIFLost");
            entity.Property(e => e.AlarmIfmotion).HasColumnName("AlarmIFMotion");
            entity.Property(e => e.AlarmIfnearstReaderChange).HasColumnName("AlarmIFNearstReaderChange");
            entity.Property(e => e.AlarmIfnotDetected).HasColumnName("AlarmIFNotDetected");
            entity.Property(e => e.AlarmIfpanic).HasColumnName("AlarmIFPanic");
            entity.Property(e => e.AlarmIfroomLocatorChange).HasColumnName("AlarmIFRoomLocatorChange");
            entity.Property(e => e.AlarmIftamper).HasColumnName("AlarmIFTamper");
            entity.Property(e => e.AlarmIfunAuthZonePass).HasColumnName("AlarmIFUnAuthZonePass");
            entity.Property(e => e.AlarmIfunCovered).HasColumnName("AlarmIFUnCovered");
            entity.Property(e => e.AlarmIfzoneChange).HasColumnName("AlarmIFZoneChange");
            entity.Property(e => e.AssetFormId).HasColumnName("AssetFormID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTransactionId).HasColumnName("AssetTransactionID");
            entity.Property(e => e.GeofencingZoneId).HasColumnName("GeofencingZoneID");
            entity.Property(e => e.RepeatAlarmIfgatePass).HasColumnName("RepeatAlarmIFGatePass");
            entity.Property(e => e.RepeatAlarmIfnearstReaderChange).HasColumnName("RepeatAlarmIFNearstReaderChange");
            entity.Property(e => e.RepeatAlarmIfroomLocatorChange).HasColumnName("RepeatAlarmIFRoomLocatorChange");
            entity.Property(e => e.RepeatAlarmIfunAuthZonePass).HasColumnName("RepeatAlarmIFUnAuthZonePass");
            entity.Property(e => e.RepeatAlarmIfzoneChange).HasColumnName("RepeatAlarmIFZoneChange");

            entity.HasOne(d => d.AssetForm).WithMany(p => p.AssetFormAlarmRoleItems)
                .HasForeignKey(d => d.AssetFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormAlarmRoleItem_AssetForm");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetFormAlarmRoleItems)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormAlarmRoleItem_Assets");

            entity.HasOne(d => d.AssetTransaction).WithMany(p => p.AssetFormAlarmRoleItems)
                .HasForeignKey(d => d.AssetTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormAlarmRoleItem_AssetTransactionLog");

            entity.HasOne(d => d.GeofencingZone).WithMany(p => p.AssetFormAlarmRoleItems)
                .HasForeignKey(d => d.GeofencingZoneId)
                .HasConstraintName("FK_AssetFormAlarmRoleItem_Zone");
        });

        modelBuilder.Entity<AssetFormAuditSession>(entity =>
        {
            entity.ToTable("AssetFormAuditSession", tb => tb.HasTrigger("AddAssetFormAuditSessionLog"));

            entity.Property(e => e.AssetFormAuditSessionId)
                .ValueGeneratedNever()
                .HasColumnName("AssetFormAuditSessionID");
            entity.Property(e => e.AuditLocationId).HasColumnName("AuditLocationID");
            entity.Property(e => e.AuditSessionTypeId).HasColumnName("AuditSessionTypeID");
            entity.Property(e => e.AuditStatusId).HasColumnName("AuditStatusID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.AssetFormAuditSessionNavigation).WithOne(p => p.AssetFormAuditSession)
                .HasForeignKey<AssetFormAuditSession>(d => d.AssetFormAuditSessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditSession_AssetForm");

            entity.HasOne(d => d.AuditLocation).WithMany(p => p.AssetFormAuditSessions)
                .HasForeignKey(d => d.AuditLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditSessions_Locations");

            entity.HasOne(d => d.AuditSessionType).WithMany(p => p.AssetFormAuditSessions)
                .HasForeignKey(d => d.AuditSessionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditSessions_LTAuditSessionTypes");

            entity.HasOne(d => d.AuditStatus).WithMany(p => p.AssetFormAuditSessions)
                .HasForeignKey(d => d.AuditStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditSession_LTAuditSessionStatus");

            entity.HasOne(d => d.ClosedByUserNavigation).WithMany(p => p.AssetFormAuditSessions)
                .HasForeignKey(d => d.ClosedByUser)
                .HasConstraintName("FK_AuditSessions_Users");
        });

        modelBuilder.Entity<AssetFormAuditSessionLog>(entity =>
        {
            entity.HasKey(e => e.AssetFormAuditSessionLog1);

            entity.ToTable("AssetFormAuditSessionLog");

            entity.Property(e => e.AssetFormAuditSessionLog1).HasColumnName("AssetFormAuditSessionLog");
            entity.Property(e => e.AssetFormAuditSessionId).HasColumnName("AssetFormAuditSessionID");
            entity.Property(e => e.AuditLocationId).HasColumnName("AuditLocationID");
            entity.Property(e => e.AuditSessionTypeId).HasColumnName("AuditSessionTypeID");
            entity.Property(e => e.AuditStatusId).HasColumnName("AuditStatusID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetFormBoxTransaction>(entity =>
        {
            entity.HasKey(e => e.AssetFormBoxTransactionId).HasName("PK_BoxTransactionForm");

            entity.ToTable("AssetFormBoxTransaction");

            entity.Property(e => e.AssetFormBoxTransactionId)
                .ValueGeneratedNever()
                .HasColumnName("AssetFormBoxTransactionID");
            entity.Property(e => e.BoxTransactionTypeId).HasColumnName("BoxTransactionTypeID");
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AssetFormBoxTransactionNavigation).WithOne(p => p.AssetFormBoxTransaction)
                .HasForeignKey<AssetFormBoxTransaction>(d => d.AssetFormBoxTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BoxTransactionForm_AssetForm");

            entity.HasOne(d => d.BoxTransactionType).WithMany(p => p.AssetFormBoxTransactions)
                .HasForeignKey(d => d.BoxTransactionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BoxTransactionForm_LTBoxTransactionTypes");
        });

        modelBuilder.Entity<AssetFormBoxTransactionItem>(entity =>
        {
            entity.HasKey(e => e.AssetFormBoxTransactionItemId).HasName("PK_BoxTransactionItem_1");

            entity.ToTable("AssetFormBoxTransactionItem");

            entity.Property(e => e.AssetFormBoxTransactionItemId).HasColumnName("AssetFormBoxTransactionItemID");
            entity.Property(e => e.AssetFormBoxTransactionId).HasColumnName("AssetFormBoxTransactionID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTransactionLogId).HasColumnName("AssetTransactionLogID");
            entity.Property(e => e.ExteraCostUnit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AssetFormBoxTransaction).WithMany(p => p.AssetFormBoxTransactionItems)
                .HasForeignKey(d => d.AssetFormBoxTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BoxTransactionItem_BoxTransactionForm");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetFormBoxTransactionItems)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BoxTransactionItem_Assets");

            entity.HasOne(d => d.AssetTransactionLog).WithMany(p => p.AssetFormBoxTransactionItems)
                .HasForeignKey(d => d.AssetTransactionLogId)
                .HasConstraintName("FK_BoxTransactionItem_AssetTransactionLog");
        });

        modelBuilder.Entity<AssetFormEditAssetItem>(entity =>
        {
            entity.ToTable("AssetFormEditAssetItem");

            entity.Property(e => e.AssetFormEditAssetItemId).HasColumnName("AssetFormEditAssetItemID");
            entity.Property(e => e.AssetFormId).HasColumnName("AssetFormID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTransactionId).HasColumnName("AssetTransactionID");
            entity.Property(e => e.NewClassId).HasColumnName("NewClassID");
            entity.Property(e => e.NewColorId).HasColumnName("NewColorID");
            entity.Property(e => e.NewCostPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NewExtraUnitCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NewPlanId).HasColumnName("NewPlanID");
            entity.Property(e => e.NewPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NewProfitUnitAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NewSalePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NewStateId).HasColumnName("NewStateID");
            entity.Property(e => e.NewUnitId).HasColumnName("NewUnitID");
            entity.Property(e => e.NewWeight)
                .HasDefaultValue(2m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NewWeightUnitId)
                .HasDefaultValue(2)
                .HasColumnName("NewWeightUnitID");
            entity.Property(e => e.PlanStartDate).HasColumnType("datetime");
            entity.Property(e => e.RemoveAssetPhoto).HasDefaultValue(false);

            entity.HasOne(d => d.AssetForm).WithMany(p => p.AssetFormEditAssetItems)
                .HasForeignKey(d => d.AssetFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormEditAssetItem_AssetForm");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetFormEditAssetItems)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormEditAssetItem_Assets");

            entity.HasOne(d => d.AssetTransaction).WithMany(p => p.AssetFormEditAssetItems)
                .HasForeignKey(d => d.AssetTransactionId)
                .HasConstraintName("FK_AssetFormEditAssetItem_AssetTransactionLog");

            entity.HasOne(d => d.NewClass).WithMany(p => p.AssetFormEditAssetItems)
                .HasForeignKey(d => d.NewClassId)
                .HasConstraintName("FK_AssetFormEditAssetItem_AssetsClassfication");

            entity.HasOne(d => d.NewColor).WithMany(p => p.AssetFormEditAssetItems)
                .HasForeignKey(d => d.NewColorId)
                .HasConstraintName("FK_AssetFormEditAssetItem_LTColor");

            entity.HasOne(d => d.NewPlan).WithMany(p => p.AssetFormEditAssetItems)
                .HasForeignKey(d => d.NewPlanId)
                .HasConstraintName("FK_AssetFormEditAssetItem_AssetMaintenancePlan");

            entity.HasOne(d => d.NewState).WithMany(p => p.AssetFormEditAssetItems)
                .HasForeignKey(d => d.NewStateId)
                .HasConstraintName("FK_AssetFormEditAssetItem_LTAssetState");

            entity.HasOne(d => d.NewUnit).WithMany(p => p.AssetFormEditAssetItemNewUnits)
                .HasForeignKey(d => d.NewUnitId)
                .HasConstraintName("FK_AssetFormEditAssetItem_LTAssetUnit");

            entity.HasOne(d => d.NewWeightUnit).WithMany(p => p.AssetFormEditAssetItemNewWeightUnits)
                .HasForeignKey(d => d.NewWeightUnitId)
                .HasConstraintName("FK_AssetFormEditAssetItem_LTAssetUnit_Weight");
        });

        modelBuilder.Entity<AssetFormEditTag>(entity =>
        {
            entity.ToTable("AssetFormEditTag");

            entity.Property(e => e.AssetFormEditTagId).HasColumnName("AssetFormEditTagID");
            entity.Property(e => e.AssetFormId).HasColumnName("AssetFormID");
            entity.Property(e => e.AssetTagId).HasColumnName("AssetTagID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.TagId).HasColumnName("TagID");
            entity.Property(e => e.Tid).HasColumnName("TID");

            entity.HasOne(d => d.AssetForm).WithMany(p => p.AssetFormEditTags)
                .HasForeignKey(d => d.AssetFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormEditTag_AssetForm");

            entity.HasOne(d => d.AssetType).WithMany(p => p.AssetFormEditTags)
                .HasForeignKey(d => d.AssetTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormEditTag_LTRFIDTagType");
        });

        modelBuilder.Entity<AssetFormEndLife>(entity =>
        {
            entity.HasKey(e => e.AssetFormId);

            entity.ToTable("AssetFormEndLife");

            entity.Property(e => e.AssetFormId)
                .ValueGeneratedNever()
                .HasColumnName("AssetFormID");
            entity.Property(e => e.DestructionTypeId).HasColumnName("DestructionTypeID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.HasOne(d => d.AssetForm).WithOne(p => p.AssetFormEndLife)
                .HasForeignKey<AssetFormEndLife>(d => d.AssetFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormEndLife_AssetForm");

            entity.HasOne(d => d.DestructionType).WithMany(p => p.AssetFormEndLives)
                .HasForeignKey(d => d.DestructionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormEndLife_LTDestructionReason");
        });

        modelBuilder.Entity<AssetFormEndLifeItem>(entity =>
        {
            entity.ToTable("AssetFormEndLifeItem");

            entity.Property(e => e.AssetFormEndLifeItemId).HasColumnName("AssetFormEndLifeItemID");
            entity.Property(e => e.AssetFormEndLifeId).HasColumnName("AssetFormEndLifeID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTransactionId).HasColumnName("AssetTransactionID");
            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

            entity.HasOne(d => d.AssetFormEndLife).WithMany(p => p.AssetFormEndLifeItems)
                .HasForeignKey(d => d.AssetFormEndLifeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormEndLifeItem_AssetFormEndLife");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetFormEndLifeItems)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormEndLifeItem_Assets");

            entity.HasOne(d => d.AssetTransaction).WithMany(p => p.AssetFormEndLifeItems)
                .HasForeignKey(d => d.AssetTransactionId)
                .HasConstraintName("FK_AssetFormEndLifeItem_AssetTransactionLog");

            entity.HasOne(d => d.Process).WithMany(p => p.AssetFormEndLifeItems)
                .HasForeignKey(d => d.ProcessId)
                .HasConstraintName("FK_AssetFormEndLifeItem_TempProcess");
        });

        modelBuilder.Entity<AssetFormGurdianshipItem>(entity =>
        {
            entity.HasKey(e => e.GurdianshipFormItemId).HasName("PK_GurdianshipFormDetail");

            entity.ToTable("AssetFormGurdianshipItem");

            entity.Property(e => e.GurdianshipFormItemId).HasColumnName("GurdianshipFormItemID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTransactionId).HasColumnName("AssetTransactionID");
            entity.Property(e => e.GurdianshipFormId).HasColumnName("GurdianshipFormID");
            entity.Property(e => e.NewStateStateId).HasColumnName("NewStateStateID");
            entity.Property(e => e.OldAssetStateId).HasColumnName("OldAssetStateID");
            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetFormGurdianshipItems)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GurdianshipFormDetail_Assets");

            entity.HasOne(d => d.AssetTransaction).WithMany(p => p.AssetFormGurdianshipItems)
                .HasForeignKey(d => d.AssetTransactionId)
                .HasConstraintName("FK_AssetFormGurdianshipItem_AssetTransactionLog");

            entity.HasOne(d => d.GurdianshipForm).WithMany(p => p.AssetFormGurdianshipItems)
                .HasForeignKey(d => d.GurdianshipFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormGurdianshipItem_AssetForm");

            entity.HasOne(d => d.NewStateState).WithMany(p => p.AssetFormGurdianshipItemNewStateStates)
                .HasForeignKey(d => d.NewStateStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GurdianshipFormDetail_NewAssetState");

            entity.HasOne(d => d.OldAssetState).WithMany(p => p.AssetFormGurdianshipItemOldAssetStates)
                .HasForeignKey(d => d.OldAssetStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GurdianshipFormItem_OldAssetState");

            entity.HasOne(d => d.Process).WithMany(p => p.AssetFormGurdianshipItems)
                .HasForeignKey(d => d.ProcessId)
                .HasConstraintName("FK_AssetFormGurdianshipItem_TempProcessGuardenItem");
        });

        modelBuilder.Entity<AssetFormItemDistribute>(entity =>
        {
            entity.HasKey(e => e.AssetFormItemId);

            entity.ToTable("AssetFormItemDistribute");

            entity.Property(e => e.AssetFormItemId).HasColumnName("AssetFormItemID");
            entity.Property(e => e.AssetFormId).HasColumnName("AssetFormID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.FromLocationId).HasColumnName("FromLocationID");
            entity.Property(e => e.NewLocationId).HasColumnName("NewLocationID");
            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            entity.Property(e => e.TransactionAssetId).HasColumnName("TransactionAssetID");

            entity.HasOne(d => d.AssetForm).WithMany(p => p.AssetFormItemDistributes)
                .HasForeignKey(d => d.AssetFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormItemDistribute_AssetForm");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetFormItemDistributes)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormItemDistribute_Assets");

            entity.HasOne(d => d.NewLocation).WithMany(p => p.AssetFormItemDistributes)
                .HasForeignKey(d => d.NewLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormItemDistribute_Location");

            entity.HasOne(d => d.TransactionAsset).WithMany(p => p.AssetFormItemDistributes)
                .HasForeignKey(d => d.TransactionAssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormItemDistribute_AssetTransactionLog");
        });

        modelBuilder.Entity<AssetFormLog>(entity =>
        {
            entity.HasKey(e => e.FormLogId);

            entity.ToTable("AssetFormLog");

            entity.Property(e => e.FormLogId).HasColumnName("FormLogID");
            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.FormProcessStateId).HasColumnName("FormProcessStateID");
            entity.Property(e => e.FormProcessedByUserId).HasColumnName("FormProcessedByUserID");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

            entity.HasOne(d => d.Form).WithMany(p => p.AssetFormLogs)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormLog_AssetForm");

            entity.HasOne(d => d.FormProcessState).WithMany(p => p.AssetFormLogs)
                .HasForeignKey(d => d.FormProcessStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormLog_LTFormProcessState");

            entity.HasOne(d => d.FormProcessedByUser).WithMany(p => p.AssetFormLogs)
                .HasForeignKey(d => d.FormProcessedByUserId)
                .HasConstraintName("FK_AssetFormLog_UserAccount");

            entity.HasOne(d => d.Transaction).WithMany(p => p.AssetFormLogs)
                .HasForeignKey(d => d.TransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormLog_SystemTransaction");
        });

        modelBuilder.Entity<AssetFormMaintenanceItem>(entity =>
        {
            entity.HasKey(e => e.AssetFormMaintainanceItemId).HasName("PK_AssetMaintenances");

            entity.ToTable("AssetFormMaintenanceItem");

            entity.Property(e => e.AssetFormMaintainanceItemId).HasColumnName("AssetFormMaintainanceItemID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetMaintenanceFormId).HasColumnName("AssetMaintenanceFormID");
            entity.Property(e => e.AssetTransactionLogId).HasColumnName("AssetTransactionLogID");
            entity.Property(e => e.ExpectedReturnDate).HasColumnType("datetime");
            entity.Property(e => e.MaintananceDate).HasColumnType("datetime");
            entity.Property(e => e.NewAssetLocationId).HasColumnName("NewAssetLocationID");
            entity.Property(e => e.NewAssetMaintenanceStatusId).HasColumnName("NewAssetMaintenanceStatusID");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetFormMaintenanceItems)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetMaintenances_Assets");

            entity.HasOne(d => d.AssetMaintenanceForm).WithMany(p => p.AssetFormMaintenanceItems)
                .HasForeignKey(d => d.AssetMaintenanceFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormMaintenanceItem_AssetForm");

            entity.HasOne(d => d.AssetTransactionLog).WithMany(p => p.AssetFormMaintenanceItems)
                .HasForeignKey(d => d.AssetTransactionLogId)
                .HasConstraintName("FK_AssetFormMaintenanceItem_AssetTransactionLog");

            entity.HasOne(d => d.NewAssetLocation).WithMany(p => p.AssetFormMaintenanceItems)
                .HasForeignKey(d => d.NewAssetLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetMaintenances_Locations");

            entity.HasOne(d => d.NewAssetMaintenanceStatus).WithMany(p => p.AssetFormMaintenanceItems)
                .HasForeignKey(d => d.NewAssetMaintenanceStatusId)
                .HasConstraintName("FK_AssetFormMaintenanceItem_LTAssetMaintenanceStatus");
        });

        modelBuilder.Entity<AssetFormRecievedItem>(entity =>
        {
            entity.ToTable("AssetFormRecievedItem");

            entity.Property(e => e.AssetFormRecievedItemId).HasColumnName("AssetFormRecievedItemID");
            entity.Property(e => e.AssetFormId).HasColumnName("AssetFormID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTransactionId).HasColumnName("AssetTransactionID");
            entity.Property(e => e.ExportFormId).HasColumnName("ExportFormID");
            entity.Property(e => e.FromLocationId).HasColumnName("FromLocationID");
            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            entity.Property(e => e.ToLocationId).HasColumnName("ToLocationID");

            entity.HasOne(d => d.AssetForm).WithMany(p => p.AssetFormRecievedItemAssetForms)
                .HasForeignKey(d => d.AssetFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormRecievedItem_AssetForm");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetFormRecievedItems)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormRecievedItem_Assets");

            entity.HasOne(d => d.AssetTransaction).WithMany(p => p.AssetFormRecievedItems)
                .HasForeignKey(d => d.AssetTransactionId)
                .HasConstraintName("FK_AssetFormRecievedItem_AssetTransactionLog");

            entity.HasOne(d => d.ExportForm).WithMany(p => p.AssetFormRecievedItemExportForms)
                .HasForeignKey(d => d.ExportFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormRecievedItem_AssetFormExport");

            entity.HasOne(d => d.FromLocation).WithMany(p => p.AssetFormRecievedItemFromLocations)
                .HasForeignKey(d => d.FromLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormRecievedItem_Location");

            entity.HasOne(d => d.ToLocation).WithMany(p => p.AssetFormRecievedItemToLocations)
                .HasForeignKey(d => d.ToLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormRecievedItem_LocationTo");
        });

        modelBuilder.Entity<AssetFormRegistrationItem>(entity =>
        {
            entity.HasKey(e => e.AssetRegistrationFormItemId).HasName("PK_AssetRegistrationForm");

            entity.ToTable("AssetFormRegistrationItem");

            entity.HasIndex(e => new { e.AssetRegistrationFormId, e.AssetId }, "_dta_index_AssetFormRegistrationItem_31_1461580245__K2_K3");

            entity.Property(e => e.AssetRegistrationFormItemId).HasColumnName("AssetRegistrationFormItemID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetRegistrationFormId).HasColumnName("AssetRegistrationFormID");
            entity.Property(e => e.AssetTransactionId).HasColumnName("AssetTransactionID");
            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetFormRegistrationItems)
                .HasForeignKey(d => d.AssetId)
                .HasConstraintName("FK_AssetRegistrationFormItem_Assets");

            entity.HasOne(d => d.AssetRegistrationForm).WithMany(p => p.AssetFormRegistrationItems)
                .HasForeignKey(d => d.AssetRegistrationFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormRegistrationItem_AssetForm");

            entity.HasOne(d => d.AssetTransaction).WithMany(p => p.AssetFormRegistrationItems)
                .HasForeignKey(d => d.AssetTransactionId)
                .HasConstraintName("FK_AssetFormRegistrationItem_AssetTransactionLog");

            entity.HasOne(d => d.Process).WithMany(p => p.AssetFormRegistrationItems)
                .HasForeignKey(d => d.ProcessId)
                .HasConstraintName("FK_AssetRegistrationFormItem_TempProcessRegistrationItem");
        });

        modelBuilder.Entity<AssetFormReturnRecieverItem>(entity =>
        {
            entity.ToTable("AssetFormReturnRecieverItem");

            entity.Property(e => e.AssetFormReturnRecieverItemId).HasColumnName("AssetFormReturnRecieverItemID");
            entity.Property(e => e.AssetFormId).HasColumnName("AssetFormID");
            entity.Property(e => e.AssetFormTransfareId).HasColumnName("AssetFormTransfareID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTransactionId).HasColumnName("AssetTransactionID");
            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

            entity.HasOne(d => d.AssetForm).WithMany(p => p.AssetFormReturnRecieverItemAssetForms)
                .HasForeignKey(d => d.AssetFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormReturnRecieverItem_AssetForm");

            entity.HasOne(d => d.AssetFormTransfare).WithMany(p => p.AssetFormReturnRecieverItemAssetFormTransfares)
                .HasForeignKey(d => d.AssetFormTransfareId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormReturnRecieverItem_AssetFormTransafre");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetFormReturnRecieverItems)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormReturnRecieverItem_Assets");

            entity.HasOne(d => d.AssetTransaction).WithMany(p => p.AssetFormReturnRecieverItems)
                .HasForeignKey(d => d.AssetTransactionId)
                .HasConstraintName("FK_AssetFormReturnRecieverItem_AssetTransactionLog");
        });

        modelBuilder.Entity<AssetFormSale>(entity =>
        {
            entity.HasKey(e => e.AssetFormId);

            entity.ToTable("AssetFormSale");

            entity.Property(e => e.AssetFormId)
                .ValueGeneratedNever()
                .HasColumnName("AssetFormID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.NetPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OriginalFormId).HasColumnName("OriginalFormID");
            entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");
            entity.Property(e => e.PoSid).HasColumnName("PoSID");
            entity.Property(e => e.SellerUserId).HasColumnName("SellerUserID");
            entity.Property(e => e.TotalDiscount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalTaxes).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AssetForm).WithOne(p => p.AssetFormSale)
                .HasForeignKey<AssetFormSale>(d => d.AssetFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSale_AssetForm");

            entity.HasOne(d => d.Location).WithMany(p => p.AssetFormSales)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSale_Location");

            entity.HasOne(d => d.OriginalForm).WithMany(p => p.InverseOriginalForm)
                .HasForeignKey(d => d.OriginalFormId)
                .HasConstraintName("FK_AssetFormSale_AssetFormSale");

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.AssetFormSales)
                .HasForeignKey(d => d.PaymentMethodId)
                .HasConstraintName("FK_AssetFormSale_LTPaymentMethod");

            entity.HasOne(d => d.PoS).WithMany(p => p.AssetFormSales)
                .HasForeignKey(d => d.PoSid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSale_SystemApps");

            entity.HasOne(d => d.SellerUser).WithMany(p => p.AssetFormSales)
                .HasForeignKey(d => d.SellerUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSale_UserAccount");
        });

        modelBuilder.Entity<AssetFormSaleFin>(entity =>
        {
            entity.ToTable("AssetFormSaleFin");

            entity.Property(e => e.AssetFormSaleFinId)
                .ValueGeneratedNever()
                .HasColumnName("AssetFormSaleFinID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.FinVoucherId).HasColumnName("FinVoucherID");

            entity.HasOne(d => d.AssetFormSaleFinNavigation).WithOne(p => p.AssetFormSaleFin)
                .HasForeignKey<AssetFormSaleFin>(d => d.AssetFormSaleFinId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSaleFin_AssetFormSale");
        });

        modelBuilder.Entity<AssetFormSaleIncomItem>(entity =>
        {
            entity.HasKey(e => e.AssetFormSaleIncomItemId).HasName("PK__AssetFor__5259A8F30936DD0");

            entity.ToTable("AssetFormSaleIncomItem");

            entity.Property(e => e.AssetFormSaleIncomItemId).HasColumnName("AssetFormSaleIncomItemID");
            entity.Property(e => e.AddedWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AssetFormSaleFormId).HasColumnName("AssetFormSaleFormID");
            entity.Property(e => e.ContainerAssetId).HasColumnName("ContainerAssetID");
            entity.Property(e => e.ContainerAssetTransactionId).HasColumnName("ContainerAssetTransactionID");
            entity.Property(e => e.CurrentWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncomeAssetId).HasColumnName("IncomeAssetID");
            entity.Property(e => e.IncomeAssetTransactionId).HasColumnName("IncomeAssetTransactionID");
            entity.Property(e => e.OrignalWeight).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AssetFormSaleForm).WithMany(p => p.AssetFormSaleIncomItems)
                .HasForeignKey(d => d.AssetFormSaleFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSaleIncomItem_AssetFormSale");

            entity.HasOne(d => d.ContainerAsset).WithMany(p => p.AssetFormSaleIncomItemContainerAssets)
                .HasForeignKey(d => d.ContainerAssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSaleIncomItem_ContainerAsset");

            entity.HasOne(d => d.ContainerAssetTransaction).WithMany(p => p.AssetFormSaleIncomItemContainerAssetTransactions)
                .HasForeignKey(d => d.ContainerAssetTransactionId)
                .HasConstraintName("FK_AssetFormSaleIncomItem_ContainerAssetLog");

            entity.HasOne(d => d.IncomeAsset).WithMany(p => p.AssetFormSaleIncomItemIncomeAssets)
                .HasForeignKey(d => d.IncomeAssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSaleIncomItem_IncomeAsset");

            entity.HasOne(d => d.IncomeAssetTransaction).WithMany(p => p.AssetFormSaleIncomItemIncomeAssetTransactions)
                .HasForeignKey(d => d.IncomeAssetTransactionId)
                .HasConstraintName("FK_AssetFormSaleIncomItem_IncomeAssetsLog");
        });

        modelBuilder.Entity<AssetFormSaleItem>(entity =>
        {
            entity.ToTable("AssetFormSaleItem");

            entity.Property(e => e.AssetFormSaleItemId).HasColumnName("AssetFormSaleItemID");
            entity.Property(e => e.AssetFormId).HasColumnName("AssetFormID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTransactionId).HasColumnName("AssetTransactionID");
            entity.Property(e => e.CancelReasonId).HasColumnName("CancelReasonID");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifyFormId).HasColumnName("ModifyFormID");
            entity.Property(e => e.OriginalExtraUnitCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OriginalProfitUnitAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrignalPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrignalUnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrignalWieght).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceAfterVat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PriceAfterVAT");
            entity.Property(e => e.PriceBeforeVat)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("PriceBeforeVAT");
            entity.Property(e => e.SaleExtraUnitCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaleProfitUnitAmount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.SaleStonesPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaleUnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaleWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SellerUserId).HasColumnName("SellerUserID");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxesPercentage).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AssetForm).WithMany(p => p.AssetFormSaleItems)
                .HasForeignKey(d => d.AssetFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSaleItem_AssetFormSale");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetFormSaleItems)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSaleItem_Assets");

            entity.HasOne(d => d.AssetTransaction).WithMany(p => p.AssetFormSaleItems)
                .HasForeignKey(d => d.AssetTransactionId)
                .HasConstraintName("FK_AssetFormSaleItem_AssetTransactionLog");
        });

        modelBuilder.Entity<AssetFormSaleReturn>(entity =>
        {
            entity.HasKey(e => e.AssetFormId);

            entity.ToTable("AssetFormSaleReturn");

            entity.Property(e => e.AssetFormId)
                .ValueGeneratedNever()
                .HasColumnName("AssetFormID");
            entity.Property(e => e.AssetSaleFormId).HasColumnName("AssetSaleFormID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.NetPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");
            entity.Property(e => e.PoSid).HasColumnName("PoSID");
            entity.Property(e => e.SellerUserId).HasColumnName("SellerUserID");
            entity.Property(e => e.TotalDiscount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalTaxes).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AssetForm).WithOne(p => p.AssetFormSaleReturn)
                .HasForeignKey<AssetFormSaleReturn>(d => d.AssetFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSaleReturn_AssetForm");

            entity.HasOne(d => d.AssetSaleForm).WithMany(p => p.AssetFormSaleReturns)
                .HasForeignKey(d => d.AssetSaleFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSaleReturn_AssetFormSale");

            entity.HasOne(d => d.Location).WithMany(p => p.AssetFormSaleReturns)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSaleReturn_Location");

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.AssetFormSaleReturns)
                .HasForeignKey(d => d.PaymentMethodId)
                .HasConstraintName("FK_AssetFormSaleReturn_LTPaymentMethod");

            entity.HasOne(d => d.PoS).WithMany(p => p.AssetFormSaleReturns)
                .HasForeignKey(d => d.PoSid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSaleReturn_SystemApps");

            entity.HasOne(d => d.SellerUser).WithMany(p => p.AssetFormSaleReturns)
                .HasForeignKey(d => d.SellerUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSaleReturn_UserAccount");
        });

        modelBuilder.Entity<AssetFormSaleReturnItem>(entity =>
        {
            entity.ToTable("AssetFormSaleReturnItem");

            entity.Property(e => e.AssetFormSaleReturnItemId).HasColumnName("AssetFormSaleReturnItemID");
            entity.Property(e => e.AssetFormSaleItemId).HasColumnName("AssetFormSaleItemID");
            entity.Property(e => e.AssetFormSaleReturnFormId).HasColumnName("AssetFormSaleReturnFormID");
            entity.Property(e => e.AssetTransactionId).HasColumnName("AssetTransactionID");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceAfterVat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PriceAfterVAT");
            entity.Property(e => e.PriceBeforeVat)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("PriceBeforeVAT");
            entity.Property(e => e.ReturnedQuantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReturnedWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxesPercentage).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AssetFormSaleItem).WithMany(p => p.AssetFormSaleReturnItems)
                .HasForeignKey(d => d.AssetFormSaleItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSaleReturnItem_AssetFormSaleItem");

            entity.HasOne(d => d.AssetFormSaleReturnForm).WithMany(p => p.AssetFormSaleReturnItems)
                .HasForeignKey(d => d.AssetFormSaleReturnFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSaleReturnItem_AssetFormSaleReturn");

            entity.HasOne(d => d.AssetTransaction).WithMany(p => p.AssetFormSaleReturnItems)
                .HasForeignKey(d => d.AssetTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormSaleReturnItemID_AssetTransactionLog");
        });

        modelBuilder.Entity<AssetFormTransferItem>(entity =>
        {
            entity.HasKey(e => e.AssetTransferFormItemId).HasName("PK_AssetTransferFormDetail");

            entity.ToTable("AssetFormTransferItem");

            entity.HasIndex(e => new { e.AssetTransferFormId, e.AssetId }, "_dta_index_AssetFormTransferItem_7_1493580359__K2_K3");

            entity.HasIndex(e => new { e.AssetTransferFormId, e.AssetId, e.AssetTransactionId, e.AssetTransferFormItemId }, "_dta_index_AssetFormTransferItem_7_1493580359__K2_K3_K4_K1");

            entity.Property(e => e.AssetTransferFormItemId).HasColumnName("AssetTransferFormItemID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTransactionId).HasColumnName("AssetTransactionID");
            entity.Property(e => e.AssetTransferFormId).HasColumnName("AssetTransferFormID");
            entity.Property(e => e.FromLocationId).HasColumnName("FromLocationID");
            entity.Property(e => e.NewAssetStateId).HasColumnName("NewAssetStateID");
            entity.Property(e => e.OldAssetStateId).HasColumnName("OldAssetStateID");
            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            entity.Property(e => e.ToLocationId).HasColumnName("ToLocationID");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetFormTransferItems)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTransferFormItem_Assets");

            entity.HasOne(d => d.AssetTransaction).WithMany(p => p.AssetFormTransferItems)
                .HasForeignKey(d => d.AssetTransactionId)
                .HasConstraintName("FK_AssetFormTransferItem_AssetTransactionLog");

            entity.HasOne(d => d.AssetTransferForm).WithMany(p => p.AssetFormTransferItems)
                .HasForeignKey(d => d.AssetTransferFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormTransferItem_AssetForm");

            entity.HasOne(d => d.FromLocation).WithMany(p => p.AssetFormTransferItemFromLocations)
                .HasForeignKey(d => d.FromLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTransferFormItem_FromLocation");

            entity.HasOne(d => d.NewAssetState).WithMany(p => p.AssetFormTransferItemNewAssetStates)
                .HasForeignKey(d => d.NewAssetStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTransferFormItem_NewLTAssetState");

            entity.HasOne(d => d.OldAssetState).WithMany(p => p.AssetFormTransferItemOldAssetStates)
                .HasForeignKey(d => d.OldAssetStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTransferFormItems_OldLTAssetStates");

            entity.HasOne(d => d.Process).WithMany(p => p.AssetFormTransferItems)
                .HasForeignKey(d => d.ProcessId)
                .HasConstraintName("FK_AssetTransferFormItem_TempProcessTransferItem");

            entity.HasOne(d => d.ToLocation).WithMany(p => p.AssetFormTransferItemToLocations)
                .HasForeignKey(d => d.ToLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTransferFormItem_ToLocation");
        });

        modelBuilder.Entity<AssetFormUserScheule>(entity =>
        {
            entity.HasKey(e => e.AssetFormUserSchudleId);

            entity.ToTable("AssetFormUserScheule");

            entity.Property(e => e.AssetFormUserSchudleId).HasColumnName("AssetFormUserSchudleID");
            entity.Property(e => e.AssetFormId).HasColumnName("AssetFormID");
            entity.Property(e => e.DayId).HasColumnName("DayID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.AssetForm).WithMany(p => p.AssetFormUserScheules)
                .HasForeignKey(d => d.AssetFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormUserScheule_AssetForm");

            entity.HasOne(d => d.Day).WithMany(p => p.AssetFormUserScheules)
                .HasForeignKey(d => d.DayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormUserScheule_LTDayName");

            entity.HasOne(d => d.User).WithMany(p => p.AssetFormUserScheules)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetFormUserScheule_UserAccount");
        });

        modelBuilder.Entity<AssetMaintenanceForm>(entity =>
        {
            entity.ToTable("AssetMaintenanceForm");

            entity.Property(e => e.AssetMaintenanceFormId)
                .ValueGeneratedNever()
                .HasColumnName("AssetMaintenanceFormID");
            entity.Property(e => e.ExpectedReturnDate).HasColumnType("datetime");
            entity.Property(e => e.MaintananceDate).HasColumnType("datetime");
            entity.Property(e => e.MaintenanceLocationId).HasColumnName("MaintenanceLocationID");
            entity.Property(e => e.MaintenanceTypeId).HasColumnName("MaintenanceTypeID");
            entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");

            entity.HasOne(d => d.AssetMaintenanceFormNavigation).WithOne(p => p.AssetMaintenanceForm)
                .HasForeignKey<AssetMaintenanceForm>(d => d.AssetMaintenanceFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetMaintenanceForm_AssetForm");

            entity.HasOne(d => d.MaintenanceLocation).WithMany(p => p.AssetMaintenanceForms)
                .HasForeignKey(d => d.MaintenanceLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetMaintenanceForm_Location");

            entity.HasOne(d => d.MaintenanceType).WithMany(p => p.AssetMaintenanceForms)
                .HasForeignKey(d => d.MaintenanceTypeId)
                .HasConstraintName("FK_AssetMaintenanceForm_LTMaintenanceType");

            entity.HasOne(d => d.Supervisor).WithMany(p => p.AssetMaintenanceForms)
                .HasForeignKey(d => d.SupervisorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetMaintenanceForm_Employee");
        });

        modelBuilder.Entity<AssetMaintenancePlan>(entity =>
        {
            entity.HasKey(e => e.MaintenancePlanId).HasName("PK_MaintenancePlane");

            entity.ToTable("AssetMaintenancePlan");

            entity.Property(e => e.MaintenancePlanId).HasColumnName("MaintenancePlanID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.AssetMaintenancePlanAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetMaintenancePlan_SystemTransaction");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.AssetMaintenancePlanUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_AssetMaintenancePlan_SystemTransaction1");
        });

        modelBuilder.Entity<AssetPrice>(entity =>
        {
            entity.HasKey(e => e.AssetId);

            entity.ToTable("AssetPrice");

            entity.HasIndex(e => e.AssetId, "_dta_index_AssetPrice_31_1773965396__K1");

            entity.HasIndex(e => e.AssetId, "_dta_index_AssetPrice_7_1773965396__K1_3");

            entity.HasIndex(e => new { e.AssetId, e.CurrentPrice }, "_dta_index_AssetPrice_7_1773965396__K1_K3");

            entity.HasIndex(e => e.CurrentPrice, "_dta_index_AssetPrice_7_1773965396__K3");

            entity.Property(e => e.AssetId)
                .ValueGeneratedNever()
                .HasColumnName("AssetID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CurrentPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExtraUnitCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FirstPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProfitUnitAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.AssetPriceAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetPrice_SystemTransaction_Add");

            entity.HasOne(d => d.Asset).WithOne(p => p.AssetPrice)
                .HasForeignKey<AssetPrice>(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetPrice_AssetPrice");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.AssetPriceUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_AssetPrice_SystemTransaction_Update");
        });

        modelBuilder.Entity<AssetReuseForm>(entity =>
        {
            entity.HasKey(e => e.AssetReuseFormId).HasName("PK_AssetReuseForms");

            entity.ToTable("AssetReuseForm");

            entity.Property(e => e.AssetReuseFormId).HasColumnName("AssetReuseFormID");
            entity.Property(e => e.CurrentGurdianshipId).HasColumnName("CurrentGurdianshipID");
            entity.Property(e => e.FormDate).HasColumnType("datetime");
            entity.Property(e => e.Gmid).HasColumnName("GMID");
            entity.Property(e => e.OldLocationId).HasColumnName("OldLocationID");
            entity.Property(e => e.RequestOrigineEmployeeId).HasColumnName("RequestOrigineEmployeeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.WarehouseEmployeeId).HasColumnName("WarehouseEmployeeID");
            entity.Property(e => e.WarehouseManagerId).HasColumnName("WarehouseManagerID");

            entity.HasOne(d => d.CurrentGurdianship).WithMany(p => p.AssetReuseFormCurrentGurdianships)
                .HasForeignKey(d => d.CurrentGurdianshipId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetReuseForms_Employees");

            entity.HasOne(d => d.OldLocation).WithMany(p => p.AssetReuseForms)
                .HasForeignKey(d => d.OldLocationId)
                .HasConstraintName("FK_AssetReuseForms_Locations");

            entity.HasOne(d => d.RequestOrigineEmployee).WithMany(p => p.AssetReuseFormRequestOrigineEmployees)
                .HasForeignKey(d => d.RequestOrigineEmployeeId)
                .HasConstraintName("FK_AssetReuseForms_Employees1");

            entity.HasOne(d => d.User).WithMany(p => p.AssetReuseForms)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetReuseForms_Users");
        });

        modelBuilder.Entity<AssetReuseFormDetail>(entity =>
        {
            entity.HasKey(e => new { e.AssetReuseFormId, e.AssetId }).HasName("PK_AssetReuseFormDetails");

            entity.ToTable("AssetReuseFormDetail");

            entity.Property(e => e.AssetReuseFormId).HasColumnName("AssetReuseFormID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.GurdianshipFormIdbeforReuse).HasColumnName("GurdianshipFormIDBeforReuse");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetReuseFormDetails)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetReuseFormDetails_Assets");

            entity.HasOne(d => d.AssetStateOnReturnNavigation).WithMany(p => p.AssetReuseFormDetails)
                .HasForeignKey(d => d.AssetStateOnReturn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetReuseFormDetails_LTAssetStates");
        });

        modelBuilder.Entity<AssetTag>(entity =>
        {
            entity.ToTable("AssetTag");

            entity.HasIndex(e => e.TagId, "IX_AssetTagID").IsUnique();

            entity.HasIndex(e => new { e.AssetId, e.TagTypeId, e.AssetTagId }, "_dta_index_AssetTag_31_612913255__K2_K4_K1_3");

            entity.HasIndex(e => e.TagTypeId, "_dta_index_AssetTag_31_612913255__K4");

            entity.HasIndex(e => new { e.AssetId, e.AssetTagId }, "_dta_index_AssetTag_7_612913255__K2_K1_3_4_5");

            entity.HasIndex(e => e.TagId, "_dta_index_AssetTag_7_612913255__K3_5");

            entity.HasIndex(e => e.TagTypeId, "_dta_index_AssetTag_7_612913255__K4_2");

            entity.HasIndex(e => new { e.TagTypeId, e.AssetId }, "_dta_index_AssetTag_7_612913255__K4_K2_1");

            entity.Property(e => e.AssetTagId).HasColumnName("AssetTagID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.TagId)
                .HasMaxLength(50)
                .HasColumnName("TagID");
            entity.Property(e => e.TagTypeId).HasColumnName("TagTypeID");
            entity.Property(e => e.Tid).HasColumnName("TID");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetTags)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTag_Assets");

            entity.HasOne(d => d.TagType).WithMany(p => p.AssetTags)
                .HasForeignKey(d => d.TagTypeId)
                .HasConstraintName("FK_AssetTag_LTRFIDTagType");
        });

        modelBuilder.Entity<AssetTagTransactionLog>(entity =>
        {
            entity.HasKey(e => e.AssetTagTransactionId);

            entity.ToTable("AssetTagTransactionLog");

            entity.HasIndex(e => e.TagTypeId, "_dta_index_AssetTagTransactionLog_31_1701581100__K5");

            entity.Property(e => e.AssetTagTransactionId).HasColumnName("AssetTagTransactionID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTransactionId).HasColumnName("AssetTransactionID");
            entity.Property(e => e.TagId).HasColumnName("TagID");
            entity.Property(e => e.TagTypeId).HasColumnName("TagTypeID");
            entity.Property(e => e.Tid).HasColumnName("TID");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetTagTransactionLogs)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTagTransactionLog_Assets");

            entity.HasOne(d => d.AssetTransaction).WithMany(p => p.AssetTagTransactionLogs)
                .HasForeignKey(d => d.AssetTransactionId)
                .HasConstraintName("FK_AssetTagTransactionLog_AssetTransactionLog");

            entity.HasOne(d => d.TagType).WithMany(p => p.AssetTagTransactionLogs)
                .HasForeignKey(d => d.TagTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTagTransactionLog_LTRFIDTagType");
        });

        modelBuilder.Entity<AssetTracking>(entity =>
        {
            entity.HasKey(e => e.AssetTrackingId).HasName("PK_AssetTrackings");

            entity.ToTable("AssetTracking");

            entity.Property(e => e.AssetTrackingId).HasColumnName("AssetTrackingID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetTrackings)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTrackings_Assets");

            entity.HasOne(d => d.Location).WithMany(p => p.AssetTrackings)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTrackings_Locations");

            entity.HasOne(d => d.Zone).WithMany(p => p.AssetTrackings)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("FK_AssetTracking_Zone");
        });

        modelBuilder.Entity<AssetTransactionLog>(entity =>
        {
            entity.HasKey(e => e.AssetTransactionId);

            entity.ToTable("AssetTransactionLog");

            entity.HasIndex(e => e.IsPendingState, "_dta_index_AssetTransactionLog_31_2023014288__K21");

            entity.Property(e => e.AssetTransactionId).HasColumnName("AssetTransactionID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AssetStateId).HasColumnName("AssetStateID");
            entity.Property(e => e.AssetWeightUnit).HasDefaultValue(2);
            entity.Property(e => e.ColorId).HasColumnName("ColorID");
            entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExtraUnitCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GurdianShipFormId).HasColumnName("GurdianShipFormID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MaintancePlanId).HasColumnName("MaintancePlanID");
            entity.Property(e => e.MaintenanceStatusId).HasColumnName("MaintenanceStatusID");
            entity.Property(e => e.ManufactureSn).HasColumnName("ManufactureSN");
            entity.Property(e => e.NewAssetFormId).HasColumnName("NewAssetFormID");
            entity.Property(e => e.PendingProcessedFormId).HasColumnName("PendingProcessedFormID");
            entity.Property(e => e.ProcessTypeId).HasColumnName("ProcessTypeID");
            entity.Property(e => e.ProfitUnitAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RealtedAssetId).HasColumnName("RealtedAssetID");
            entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.StartMaintancePlanDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionReasoneId).HasColumnName("TransactionReasoneID");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.AssetTransactionLogAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .HasConstraintName("FK_AssetTransactionLog_AddSystemTransaction");

            entity.HasOne(d => d.AssetClass).WithMany(p => p.AssetTransactionLogs)
                .HasForeignKey(d => d.AssetClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTransactionLog_AssetsClassfications");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetTransactionLogAssets)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTransactionLog_Assets");

            entity.HasOne(d => d.AssetState).WithMany(p => p.AssetTransactionLogs)
                .HasForeignKey(d => d.AssetStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTransactionLog_LTAssetState");

            entity.HasOne(d => d.AssetUnitNavigation).WithMany(p => p.AssetTransactionLogAssetUnitNavigations)
                .HasForeignKey(d => d.AssetUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTransactionLog_LTAssetUnit");

            entity.HasOne(d => d.AssetWeightUnitNavigation).WithMany(p => p.AssetTransactionLogAssetWeightUnitNavigations)
                .HasForeignKey(d => d.AssetWeightUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTransactionLog_LTAssetUnit_Weight");

            entity.HasOne(d => d.Color).WithMany(p => p.AssetTransactionLogs)
                .HasForeignKey(d => d.ColorId)
                .HasConstraintName("FK_AssetTransactionLog_LTColor");

            entity.HasOne(d => d.GurdianShipForm).WithMany(p => p.AssetTransactionLogGurdianShipForms)
                .HasForeignKey(d => d.GurdianShipFormId)
                .HasConstraintName("FK_AssetTransactionLog_GurdianshipForm");

            entity.HasOne(d => d.Location).WithMany(p => p.AssetTransactionLogs)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTransactionLog_Location");

            entity.HasOne(d => d.MaintancePlan).WithMany(p => p.AssetTransactionLogs)
                .HasForeignKey(d => d.MaintancePlanId)
                .HasConstraintName("FK_AssetTransactionLog_AssetMaintenancePlan");

            entity.HasOne(d => d.MaintenanceStatus).WithMany(p => p.AssetTransactionLogs)
                .HasForeignKey(d => d.MaintenanceStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTransactionLog_LTAssetMaintenanceStatus");

            entity.HasOne(d => d.NewAssetForm).WithMany(p => p.AssetTransactionLogNewAssetForms)
                .HasForeignKey(d => d.NewAssetFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTransactionLog_AssetForm");

            entity.HasOne(d => d.PendingProcessedForm).WithMany(p => p.AssetTransactionLogPendingProcessedForms)
                .HasForeignKey(d => d.PendingProcessedFormId)
                .HasConstraintName("FK_AssetTransactionLog_PendingProcessedAssetForm");

            entity.HasOne(d => d.ProcessType).WithMany(p => p.AssetTransactionLogs)
                .HasForeignKey(d => d.ProcessTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTransactionLog_LTProcessType");

            entity.HasOne(d => d.RealtedAsset).WithMany(p => p.AssetTransactionLogRealtedAssets)
                .HasForeignKey(d => d.RealtedAssetId)
                .HasConstraintName("FK_AssetTransactionLog_Assets1");

            entity.HasOne(d => d.TransactionReasone).WithMany(p => p.AssetTransactionLogs)
                .HasForeignKey(d => d.TransactionReasoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTransactionLog_LTAssetTransferReason");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.AssetTransactionLogUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_AssetTransactionLog_SystemTransaction");

            entity.HasOne(d => d.User).WithMany(p => p.AssetTransactionLogs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_AssetTransactionLog_Users");
        });

        modelBuilder.Entity<AssetWarehouse>(entity =>
        {
            entity.ToTable("AssetWarehouse");

            entity.Property(e => e.AssetWarehouseId).HasColumnName("AssetWarehouseID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.WarehouseFormId).HasColumnName("WarehouseFormID");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetWarehouses)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetWarehouse_Assets");

            entity.HasOne(d => d.WarehouseForm).WithMany(p => p.AssetWarehouses)
                .HasForeignKey(d => d.WarehouseFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetWarehouse_AssetWarehouseForm");
        });

        modelBuilder.Entity<AssetsAndTag>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Assets_and_Tags");

            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetStateId).HasColumnName("AssetStateID");
            entity.Property(e => e.AssetTagId).HasColumnName("AssetTagID");
            entity.Property(e => e.ColorId).HasColumnName("ColorID");
            entity.Property(e => e.Gpslocation)
                .HasMaxLength(50)
                .HasColumnName("GPSLocation");
            entity.Property(e => e.GurdianShipFormId).HasColumnName("GurdianShipFormID");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MaintancePlanId).HasColumnName("MaintancePlanID");
            entity.Property(e => e.MaintenanceStatusId).HasColumnName("MaintenanceStatusID");
            entity.Property(e => e.ManufactureSn).HasColumnName("ManufactureSN");
            entity.Property(e => e.PendingProcessedFormId).HasColumnName("PendingProcessedFormID");
            entity.Property(e => e.RealtedAssetId).HasColumnName("RealtedAssetID");
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            entity.Property(e => e.SaveAssetDate).HasColumnType("datetime");
            entity.Property(e => e.StartMaintancePlanDate).HasColumnType("datetime");
            entity.Property(e => e.TagId)
                .HasMaxLength(50)
                .HasColumnName("TagID");
            entity.Property(e => e.TagTypeId).HasColumnName("TagTypeID");
            entity.Property(e => e.Tid).HasColumnName("TID");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<AssetsClassProfile>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PK_AssetsClassProfile_1");

            entity.ToTable("AssetsClassProfile", tb => tb.HasTrigger("AddAssetsClassProfileLog"));

            entity.HasIndex(e => new { e.ClassId, e.AddTransactionId, e.UpdateTransactionId }, "_dta_index_AssetsClassProfile_7_1699537138__K1_K16_K17");

            entity.Property(e => e.ClassId)
                .ValueGeneratedNever()
                .HasColumnName("ClassID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.ContainerHaveFixedExtraCost).HasDefaultValue(true);
            entity.Property(e => e.ContainerModeId)
                .HasDefaultValue(1)
                .HasColumnName("ContainerModeID");
            entity.Property(e => e.DefaultExtraUnitCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultProfitUnitAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultSalePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultUnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefualtMaintancePlanId).HasColumnName("DefualtMaintancePlanID");
            entity.Property(e => e.DefualtPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.StartMaintancePlanDate).HasColumnType("datetime");
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");
            entity.Property(e => e.Vat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VAT");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.AssetsClassProfileAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetsClassProfile_AddSystemTransaction");

            entity.HasOne(d => d.Class).WithOne(p => p.AssetsClassProfile)
                .HasForeignKey<AssetsClassProfile>(d => d.ClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetsClassProfile_AssetsClassfication1");

            entity.HasOne(d => d.ContainerMode).WithMany(p => p.AssetsClassProfiles)
                .HasForeignKey(d => d.ContainerModeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetsClassProfile_LTContainerMode");

            entity.HasOne(d => d.DefualtMaintancePlan).WithMany(p => p.AssetsClassProfiles)
                .HasForeignKey(d => d.DefualtMaintancePlanId)
                .HasConstraintName("FK_AssetsClassProfile_AssetMaintenancePlan");

            entity.HasOne(d => d.ItemDefualtUnitNavigation).WithMany(p => p.AssetsClassProfileItemDefualtUnitNavigations)
                .HasForeignKey(d => d.ItemDefualtUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetsClassProfile_LTAssetUnit");

            entity.HasOne(d => d.Type).WithMany(p => p.AssetsClassProfiles)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetsClassProfile_LTAssetType");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.AssetsClassProfileUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_AssetsClassProfile_UpdateSystemTransaction");

            entity.HasOne(d => d.WeightDefualtUnitNavigation).WithMany(p => p.AssetsClassProfileWeightDefualtUnitNavigations)
                .HasForeignKey(d => d.WeightDefualtUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetsClassProfile_LTAssetUnit_Weight");
        });

        modelBuilder.Entity<AssetsClassProfileLog>(entity =>
        {
            entity.ToTable("AssetsClassProfileLog");

            entity.Property(e => e.AssetsClassProfileLogId).HasColumnName("AssetsClassProfileLogID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ContainerHaveFixedExtraCost).HasDefaultValue(true);
            entity.Property(e => e.ContainerModeId)
                .HasDefaultValue(1)
                .HasColumnName("ContainerModeID");
            entity.Property(e => e.DefaultExtraUnitCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultProfitUnitAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultSalePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultUnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefualtMaintancePlanId).HasColumnName("DefualtMaintancePlanID");
            entity.Property(e => e.DefualtPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.StartMaintancePlanDate).HasColumnType("datetime");
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");
            entity.Property(e => e.Vat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VAT");
        });

        modelBuilder.Entity<AssetsClassfication>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PK_AssetsClassfications");

            entity.ToTable("AssetsClassfication");

            entity.HasIndex(e => e.IsDeleted, "NonClusteredIndex-20220411-015803");

            entity.HasIndex(e => e.ClassId, "_dta_index_AssetsClassfication_31_261575970__K1");

            entity.HasIndex(e => e.ClassId, "_dta_index_AssetsClassfication_7_261575970__K1_3_4_5_6");

            entity.HasIndex(e => e.ClassId, "_dta_index_AssetsClassfication_7_261575970__K1_4");

            entity.HasIndex(e => new { e.ClassId, e.UpdateTransactionId, e.AddTransactionId, e.IsDeleted }, "_dta_index_AssetsClassfication_7_261575970__K1_K11_K10");

            entity.HasIndex(e => new { e.ClassId, e.ClassImage }, "_dta_index_AssetsClassfication_7_261575970__K1_K6_2_3_4_5_7");

            entity.HasIndex(e => e.ParentClassId, "_dta_index_AssetsClassfication_7_261575970__K2");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.ClassImage)
                .HasMaxLength(100)
                .HasDefaultValue("NoPhoto.png");
            entity.Property(e => e.ClassLevelId).HasColumnName("ClassLevelID");
            entity.Property(e => e.ClassName).HasDefaultValue("");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LevelNodeCode).HasMaxLength(50);
            entity.Property(e => e.ParentClassId).HasColumnName("ParentClassID");
            entity.Property(e => e.RefId).HasColumnName("RefID");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.AssetsClassficationAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetsClassfication_SystemTransaction");

            entity.HasOne(d => d.ClassLevel).WithMany(p => p.AssetsClassfications)
                .HasForeignKey(d => d.ClassLevelId)
                .HasConstraintName("FK_AssetsClassfications_AssetsClassficationsLevels");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.AssetsClassficationUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_AssetsClassfication_SystemTransaction1");
        });

        modelBuilder.Entity<AssetsClassficationsLevel>(entity =>
        {
            entity.HasKey(e => e.ClassLevelId).HasName("PK_AssetsClassficationTreeLevels");

            entity.ToTable("AssetsClassficationsLevel");

            entity.Property(e => e.ClassLevelId).HasColumnName("ClassLevelID");
        });

        modelBuilder.Entity<AuditSessionClassResult>(entity =>
        {
            entity.HasKey(e => e.AuditSessionResultId);

            entity.ToTable("AuditSessionClassResult");

            entity.HasIndex(e => new { e.AssetFormAuditSessionId, e.ClassId }, "_dta_index_AuditSessionClassResult_7_1398296041__K2_K4_10");

            entity.HasIndex(e => new { e.AssetFormAuditSessionId, e.ClassId }, "_dta_index_AuditSessionClassResult_7_1398296041__K2_K4_6");

            entity.HasIndex(e => new { e.AssetFormAuditSessionId, e.ClassId }, "_dta_index_AuditSessionClassResult_7_1398296041__K2_K4_7");

            entity.HasIndex(e => new { e.AssetFormAuditSessionId, e.ClassId }, "_dta_index_AuditSessionClassResult_7_1398296041__K2_K4_8");

            entity.HasIndex(e => new { e.AssetFormAuditSessionId, e.ClassId }, "_dta_index_AuditSessionClassResult_7_1398296041__K2_K4_9");

            entity.HasIndex(e => new { e.AuditLocation, e.AssetFormAuditSessionId }, "_dta_index_AuditSessionClassResult_7_1398296041__K3_K2_6");

            entity.HasIndex(e => new { e.AuditLocation, e.AssetFormAuditSessionId }, "_dta_index_AuditSessionClassResult_7_1398296041__K3_K2_7_9_11");

            entity.HasIndex(e => new { e.AuditLocation, e.AssetFormAuditSessionId }, "_dta_index_AuditSessionClassResult_7_1398296041__K3_K2_8");

            entity.HasIndex(e => new { e.AuditLocation, e.ClassId }, "_dta_index_AuditSessionClassResult_7_1398296041__K3_K4_1_2_10");

            entity.HasIndex(e => new { e.ClassId, e.AssetFormAuditSessionId }, "_dta_index_AuditSessionClassResult_7_1398296041__K4_K2_10");

            entity.HasIndex(e => new { e.ClassId, e.AssetFormAuditSessionId }, "_dta_index_AuditSessionClassResult_7_1398296041__K4_K2_11");

            entity.HasIndex(e => new { e.ClassId, e.AssetFormAuditSessionId }, "_dta_index_AuditSessionClassResult_7_1398296041__K4_K2_6");

            entity.HasIndex(e => new { e.ClassId, e.AssetFormAuditSessionId }, "_dta_index_AuditSessionClassResult_7_1398296041__K4_K2_7_8_9");

            entity.Property(e => e.AuditSessionResultId).HasColumnName("AuditSessionResultID");
            entity.Property(e => e.AssetFormAuditSessionId).HasColumnName("AssetFormAuditSessionID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.WeightOfFound).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WeightOfLost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WeightOfRegisterd).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AssetFormAuditSession).WithMany(p => p.AuditSessionClassResults)
                .HasForeignKey(d => d.AssetFormAuditSessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditSessionClassResult_AssetFormAuditSession");

            entity.HasOne(d => d.AuditLocationNavigation).WithMany(p => p.AuditSessionClassResults)
                .HasForeignKey(d => d.AuditLocation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditSessionClassResult_Location");

            entity.HasOne(d => d.Class).WithMany(p => p.AuditSessionClassResults)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditSessionClassResult_AssetsClassfication");
        });

        modelBuilder.Entity<AuditSessionPresentAsset>(entity =>
        {
            entity.HasKey(e => e.AuditSessionPresentId).HasName("PK_AuditSessionPresentAssets");

            entity.ToTable("AuditSessionPresentAsset");

            entity.HasIndex(e => new { e.AssetId, e.AuditSessionPresentId }, "UniqueAudit_AuditSessionPresentAsset").IsUnique();

            entity.Property(e => e.AuditSessionPresentId).HasColumnName("AuditSessionPresentID");
            entity.Property(e => e.AssetFormAuditSessionId).HasColumnName("AssetFormAuditSessionID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTransactionId).HasColumnName("AssetTransactionID");
            entity.Property(e => e.AuditDate).HasColumnType("datetime");
            entity.Property(e => e.IsFound).HasDefaultValue(true);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.AssetFormAuditSession).WithMany(p => p.AuditSessionPresentAssets)
                .HasForeignKey(d => d.AssetFormAuditSessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditSessionPresentAsset_AssetFormAuditSession");

            entity.HasOne(d => d.Asset).WithMany(p => p.AuditSessionPresentAssets)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditSessionPresentAssets_Assets");

            entity.HasOne(d => d.AssetTransaction).WithMany(p => p.AuditSessionPresentAssets)
                .HasForeignKey(d => d.AssetTransactionId)
                .HasConstraintName("FK_AuditSessionPresentAsset_AssetTransactionLog");

            entity.HasOne(d => d.Location).WithMany(p => p.AuditSessionPresentAssets)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditSessionPresentAssets_Locations");

            entity.HasOne(d => d.User).WithMany(p => p.AuditSessionPresentAssets)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_AuditSessionPresentAsset_UserAccount");
        });

        modelBuilder.Entity<AuditSessionResult>(entity =>
        {
            entity.HasKey(e => e.AuditSessionResultId).HasName("PK_AuditSessionResults");

            entity.ToTable("AuditSessionResult");

            entity.Property(e => e.AuditSessionResultId).HasColumnName("AuditSessionResultID");
            entity.Property(e => e.AssetFormAuditSessionId).HasColumnName("AssetFormAuditSessionID");
            entity.Property(e => e.AuditDate).HasColumnType("datetime");

            entity.HasOne(d => d.AssetFormAuditSession).WithMany(p => p.AuditSessionResults)
                .HasForeignKey(d => d.AssetFormAuditSessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditSessionResult_AssetFormAuditSession");

            entity.HasOne(d => d.AuditLocationNavigation).WithMany(p => p.AuditSessionResults)
                .HasForeignKey(d => d.AuditLocation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditSessionResults_Locations");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.ToTable("Branch");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.LicenseId).HasColumnName("LicenseID");

            entity.HasOne(d => d.License).WithMany(p => p.Branches)
                .HasForeignKey(d => d.LicenseId)
                .HasConstraintName("FK_Branch_License");
        });

        modelBuilder.Entity<CfvTag>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CFV_Tags");

            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetId2).HasColumnName("AssetID2");
            entity.Property(e => e.FieldValue).HasMaxLength(100);
            entity.Property(e => e.TagId)
                .HasMaxLength(50)
                .HasColumnName("TagID");
            entity.Property(e => e.TitleAr)
                .HasMaxLength(100)
                .HasColumnName("TitleAR");
            entity.Property(e => e.TitleEn)
                .HasMaxLength(100)
                .HasColumnName("TitleEN");
        });

        modelBuilder.Entity<ClildernClassfication>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ClildernClassfication");

            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.ClassId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ClassID");
            entity.Property(e => e.ClassImage).HasMaxLength(100);
            entity.Property(e => e.ClassLevelId).HasColumnName("ClassLevelID");
            entity.Property(e => e.LevelNodeCode).HasMaxLength(50);
            entity.Property(e => e.ParentClassId).HasColumnName("ParentClassID");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");
        });

        modelBuilder.Entity<CountCustomValue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Count_CustomValues");
        });

        modelBuilder.Entity<CustomFieldsDefinition>(entity =>
        {
            entity.HasKey(e => e.FieldId);

            entity.ToTable("CustomFieldsDefinition");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.TitleAr)
                .HasMaxLength(100)
                .HasColumnName("TitleAR");
            entity.Property(e => e.TitleEn)
                .HasMaxLength(100)
                .HasColumnName("TitleEN");

            entity.HasOne(d => d.Class).WithMany(p => p.CustomFieldsDefinitions)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomFieldsDefinition_AssetsClassfication");

            entity.HasOne(d => d.Type).WithMany(p => p.CustomFieldsDefinitions)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomFieldsDefinition_LTCustomFieldsType");
        });

        modelBuilder.Entity<CustomFieldsOption>(entity =>
        {
            entity.HasKey(e => e.FieldOptionId);

            entity.ToTable("CustomFieldsOption");

            entity.Property(e => e.TitleAr)
                .HasMaxLength(50)
                .HasColumnName("TitleAR");
            entity.Property(e => e.TitleEn)
                .HasMaxLength(50)
                .HasColumnName("TitleEN");

            entity.HasOne(d => d.Field).WithMany(p => p.CustomFieldsOptions)
                .HasForeignKey(d => d.FieldId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomFieldsOption_CustomFieldsDefinition");
        });

        modelBuilder.Entity<CustomFieldsValue>(entity =>
        {
            entity.HasKey(e => e.FieldValueId);

            entity.ToTable("CustomFieldsValue");

            entity.Property(e => e.FieldValue).HasMaxLength(100);
            entity.Property(e => e.TitleAr)
                .HasMaxLength(100)
                .HasColumnName("TitleAR");
            entity.Property(e => e.TitleEn)
                .HasMaxLength(100)
                .HasColumnName("TitleEN");

            entity.HasOne(d => d.Asset).WithMany(p => p.CustomFieldsValues)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomFieldsValue_CustomFieldsDefinition");
        });

        modelBuilder.Entity<DeprceationDataView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DeprceationDataView");

            entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.ClassImage).HasMaxLength(100);
            entity.Property(e => e.CurrentPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FirstPrice).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<DepreciationPlan>(entity =>
        {
            entity.ToTable("DepreciationPlan");

            entity.Property(e => e.DepreciationPlanId).HasColumnName("DepreciationPlanID");
            entity.Property(e => e.DepreciationDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

            entity.HasOne(d => d.Transaction).WithMany(p => p.DepreciationPlans)
                .HasForeignKey(d => d.TransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepreciationPlan_SystemTransaction");
        });

        modelBuilder.Entity<EmailLog>(entity =>
        {
            entity.ToTable("EmailLog");

            entity.Property(e => e.EmailLogId).HasColumnName("EmailLogID");
            entity.Property(e => e.Message).HasColumnType("text");
            entity.Property(e => e.SendDate).HasColumnType("datetime");
            entity.Property(e => e.UserEmail).HasMaxLength(50);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK_Employees");

            entity.ToTable("Employee");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EmployeeSocialId).HasColumnName("EmployeeSocialID");
            entity.Property(e => e.IntgId).HasColumnName("IntgID");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employees_EmployeeDeparments");

            entity.HasOne(d => d.Transaction).WithMany(p => p.Employees)
                .HasForeignKey(d => d.TransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employee_SystemTransaction");
        });

        modelBuilder.Entity<EmployeeDeparment>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK_EmployeeDeparments");

            entity.ToTable("EmployeeDeparment");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IntgId).HasColumnName("IntgID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

            entity.HasOne(d => d.Location).WithMany(p => p.EmployeeDeparments)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_EmployeeDeparment_Location");

            entity.HasOne(d => d.Transaction).WithMany(p => p.EmployeeDeparments)
                .HasForeignKey(d => d.TransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeDeparment_SystemTransaction");
        });

        modelBuilder.Entity<EmployeeSign>(entity =>
        {
            entity.HasKey(e => e.SignId);

            entity.ToTable("EmployeeSign");

            entity.Property(e => e.SignId).HasColumnName("SignID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.EmployeeDepId).HasColumnName("EmployeeDepID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.EmployeeSigns)
                .HasForeignKey(d => d.AddTransactionId)
                .HasConstraintName("FK_EmployeeSign_SystemTransaction");

            entity.HasOne(d => d.EmployeeDep).WithMany(p => p.EmployeeSigns)
                .HasForeignKey(d => d.EmployeeDepId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeSign_EmployeeDeparment");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeSigns)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeSign_Employee");
        });

        modelBuilder.Entity<EmployeeTag>(entity =>
        {
            entity.ToTable("EmployeeTag");

            entity.Property(e => e.EmployeeTagId).HasColumnName("EmployeeTagID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.TagId)
                .HasMaxLength(50)
                .HasColumnName("TagID");
            entity.Property(e => e.TagTypeId).HasColumnName("TagTypeID");
            entity.Property(e => e.Tid).HasColumnName("TID");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeTags)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTag_Employee");
        });

        modelBuilder.Entity<EmployeeTracking>(entity =>
        {
            entity.ToTable("EmployeeTracking");

            entity.Property(e => e.EmployeeTrackingId).HasColumnName("EmployeeTrackingID");
            entity.Property(e => e.ActionDate).HasColumnType("datetime");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.AntennaId).HasColumnName("AntennaID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsOut).HasColumnName("IsOUT");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ReaderId).HasColumnName("ReaderID");
            entity.Property(e => e.ReadingSsi).HasColumnName("ReadingSSI");
            entity.Property(e => e.Xposition).HasColumnName("XPosition");
            entity.Property(e => e.Yposition).HasColumnName("YPosition");
            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

            entity.HasOne(d => d.Antenna).WithMany(p => p.EmployeeTrackings)
                .HasForeignKey(d => d.AntennaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTracking_RFIDAntenna");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeTrackings)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTracking_Employee");

            entity.HasOne(d => d.Location).WithMany(p => p.EmployeeTrackings)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTracking_Location");

            entity.HasOne(d => d.Reader).WithMany(p => p.EmployeeTrackings)
                .HasForeignKey(d => d.ReaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTracking_Hardware");

            entity.HasOne(d => d.Zone).WithMany(p => p.EmployeeTrackings)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("FK_EmployeeTracking_Zone");
        });

        modelBuilder.Entity<EmployeeTrackingLog>(entity =>
        {
            entity.ToTable("EmployeeTrackingLog");

            entity.Property(e => e.EmployeeTrackingLogId).HasColumnName("EmployeeTrackingLogID");
            entity.Property(e => e.AntennaFunctionId).HasColumnName("AntennaFunctionID");
            entity.Property(e => e.AntennaId).HasColumnName("AntennaID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EnteranceDate).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ReaderId).HasColumnName("ReaderID");
            entity.Property(e => e.ReadingSsi).HasColumnName("ReadingSSI");
            entity.Property(e => e.Xposition).HasColumnName("XPosition");
            entity.Property(e => e.Yposition).HasColumnName("YPosition");
            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

            entity.HasOne(d => d.AntennaFunction).WithMany(p => p.EmployeeTrackingLogs)
                .HasForeignKey(d => d.AntennaFunctionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTrackingLog_LTAntennaFunction");

            entity.HasOne(d => d.Antenna).WithMany(p => p.EmployeeTrackingLogs)
                .HasForeignKey(d => d.AntennaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTrackingLog_RFIDAntenna");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeTrackingLogs)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTrackingLog_Employee");

            entity.HasOne(d => d.Location).WithMany(p => p.EmployeeTrackingLogs)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTrackingLog_Location");

            entity.HasOne(d => d.Reader).WithMany(p => p.EmployeeTrackingLogs)
                .HasForeignKey(d => d.ReaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTrackingLog_RFIDPassiveReader");

            entity.HasOne(d => d.Zone).WithMany(p => p.EmployeeTrackingLogs)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("FK_EmployeeTrackingLog_Zone");
        });

        modelBuilder.Entity<ExtraGeofencedAsset>(entity =>
        {
            entity.HasKey(e => e.ExtraGeofencedAssetId).HasName("PK_ExtraGeofencedAssets");

            entity.ToTable("ExtraGeofencedAsset");

            entity.Property(e => e.ExtraGeofencedAssetId).HasColumnName("ExtraGeofencedAssetID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AuditSessionId).HasColumnName("AuditSessionID");
            entity.Property(e => e.CurrentLocationId).HasColumnName("CurrentLocationID");
            entity.Property(e => e.ExtraDate).HasColumnType("datetime");

            entity.HasOne(d => d.Asset).WithMany(p => p.ExtraGeofencedAssets)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExtraGeofencedAssets_Assets");

            entity.HasOne(d => d.CurrentLocation).WithMany(p => p.ExtraGeofencedAssets)
                .HasForeignKey(d => d.CurrentLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExtraGeofencedAssets_Locations");
        });

        modelBuilder.Entity<FormSign>(entity =>
        {
            entity.ToTable("FormSign");

            entity.Property(e => e.FormSignId).HasColumnName("FormSignID");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.SignId).HasColumnName("SignID");

            entity.HasOne(d => d.Service).WithMany(p => p.FormSigns)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormSign_SystemService");

            entity.HasOne(d => d.Sign).WithMany(p => p.FormSigns)
                .HasForeignKey(d => d.SignId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormSign_EmployeeSign");
        });

        modelBuilder.Entity<GetGuardianShip>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GetGuardianShip");

            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.GurdianshipFormId).HasColumnName("GurdianshipFormID");
            entity.Property(e => e.NewEmployeeId).HasColumnName("NewEmployeeID");
            entity.Property(e => e.TagId)
                .HasMaxLength(50)
                .HasColumnName("TagID");
        });

        modelBuilder.Entity<GroupPrivilege>(entity =>
        {
            entity.ToTable("GroupPrivilege");

            entity.Property(e => e.GroupPrivilegeId).HasColumnName("GroupPrivilegeID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.ServiceFunctionId).HasColumnName("ServiceFunctionID");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.GroupPrivileges)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GroupPrivilege_SystemTransaction");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupPrivileges)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GroupPrivileges_UserGroups");

            entity.HasOne(d => d.ServiceFunction).WithMany(p => p.GroupPrivileges)
                .HasForeignKey(d => d.ServiceFunctionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GroupPrivilege_ServiceFunction");

            entity.HasOne(d => d.Service).WithMany(p => p.GroupPrivileges)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GroupPrivileges_MainMenu");
        });

        modelBuilder.Entity<Hardware>(entity =>
        {
            entity.ToTable("Hardware");

            entity.HasIndex(e => e.HardwareIp, "IX_Hardware_UniqueIP").IsUnique();

            entity.Property(e => e.HardwareId).HasColumnName("HardwareID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.HardwareIp)
                .HasMaxLength(50)
                .HasColumnName("HardwareIP");
            entity.Property(e => e.HardwareMacadress)
                .HasDefaultValue("-")
                .HasColumnName("HardwareMACAdress");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.SwitchId).HasColumnName("SwitchID");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");
            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.HardwareAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hardware_SystemTransaction");

            entity.HasOne(d => d.HardwareTypeNavigation).WithMany(p => p.Hardwares)
                .HasForeignKey(d => d.HardwareType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hardware_LTHardwareType");

            entity.HasOne(d => d.Location).WithMany(p => p.Hardwares)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hardware_Location");

            entity.HasOne(d => d.Switch).WithMany(p => p.Hardwares)
                .HasForeignKey(d => d.SwitchId)
                .HasConstraintName("FK_SwitcheHardware_Switches");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.HardwareUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_Hardware_SystemTransaction1");

            entity.HasOne(d => d.Zone).WithMany(p => p.Hardwares)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("FK_Hardware_Zone");
        });

        modelBuilder.Entity<HardwareConnectionLog>(entity =>
        {
            entity.ToTable("HardwareConnectionLog");

            entity.Property(e => e.HardwareConnectionLogId).HasColumnName("HardwareConnectionLogID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.HardwareConnectionStateId).HasColumnName("HardwareConnectionStateID");
            entity.Property(e => e.HardwareId).HasColumnName("HardwareID");

            entity.HasOne(d => d.HardwareConnectionState).WithMany(p => p.HardwareConnectionLogs)
                .HasForeignKey(d => d.HardwareConnectionStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HardwareConnectionLog_Hardware1");
        });

        modelBuilder.Entity<IsPrivate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_IsPrivate");

            entity.Property(e => e.IsPrivate1)
                .HasMaxLength(50)
                .HasColumnName("IsPrivate");
            entity.Property(e => e.TagId)
                .HasMaxLength(50)
                .HasColumnName("TagID");
        });

        modelBuilder.Entity<IsPrivateCfvtag>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("IsPrivate_CFVTags");

            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetId2).HasColumnName("AssetID2");
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.FieldValue).HasMaxLength(100);
            entity.Property(e => e.IsPrivate).HasMaxLength(50);
            entity.Property(e => e.TagId)
                .HasMaxLength(50)
                .HasColumnName("TagID");
            entity.Property(e => e.TitleAr)
                .HasMaxLength(100)
                .HasColumnName("TitleAR");
            entity.Property(e => e.TitleEn)
                .HasMaxLength(100)
                .HasColumnName("TitleEN");
        });

        modelBuilder.Entity<LastMonthProcessReportView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LastMonthProcessReportView");

            entity.Property(e => e.LastDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<License>(entity =>
        {
            entity.ToTable("License");

            entity.Property(e => e.LicenseId).HasColumnName("LicenseID");
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.Mcode).HasColumnName("MCode");
            entity.Property(e => e.RequestdDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LiteService>(entity =>
        {
            entity.HasKey(e => e.ServiceId);

            entity.ToTable("LiteService");

            entity.Property(e => e.ServiceId)
                .ValueGeneratedNever()
                .HasColumnName("ServiceID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsMenuItem).HasDefaultValue(true);
            entity.Property(e => e.ParentServiceId).HasColumnName("ParentServiceID");

            entity.HasOne(d => d.ParentService).WithMany(p => p.InverseParentService)
                .HasForeignKey(d => d.ParentServiceId)
                .HasConstraintName("FK_LiteService_LiteService");
        });

        modelBuilder.Entity<LiteUserService>(entity =>
        {
            entity.HasKey(e => e.LiteServiceId);

            entity.ToTable("LiteUserService");

            entity.Property(e => e.LiteServiceId).HasColumnName("LiteServiceID");
            entity.Property(e => e.AdeddTransactionId).HasColumnName("AdeddTransactionID");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.AdeddTransaction).WithMany(p => p.LiteUserServices)
                .HasForeignKey(d => d.AdeddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LiteUserService_SystemTransaction");

            entity.HasOne(d => d.Service).WithMany(p => p.LiteUserServices)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LiteUserService_LiteService");

            entity.HasOne(d => d.User).WithMany(p => p.LiteUserServices)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LiteUserService_UserAccount");
        });

        modelBuilder.Entity<LocalizationString>(entity =>
        {
            entity.HasKey(e => new { e.EntityId, e.ForginEntityId, e.LanguageId });

            entity.ToTable("LocalizationString");

            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.ForginEntityId).HasColumnName("ForginEntityID");
            entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            entity.Property(e => e.LocalizationStringId).HasColumnName("LocalizationStringID");

            entity.HasOne(d => d.Entity).WithMany(p => p.LocalizationStrings)
                .HasForeignKey(d => d.EntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocalizationString_LTSystemEntities");

            entity.HasOne(d => d.ForginEntity).WithMany(p => p.LocalizationStrings)
                .HasForeignKey(d => d.ForginEntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocalizationString_LTBackupType");

            entity.HasOne(d => d.ForginEntityNavigation).WithMany(p => p.LocalizationStrings)
                .HasForeignKey(d => d.ForginEntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocalizationString_SystemService");

            entity.HasOne(d => d.Language).WithMany(p => p.LocalizationStrings)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocalizationString_LTLanguage");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK_Locations");

            entity.ToTable("Location");

            entity.HasIndex(e => new { e.LocationId, e.AddTransactionId, e.UpdateTransactionId, e.IsDeleted }, "NonClusteredIndex-20220411-013638");

            entity.HasIndex(e => e.LocationId, "_dta_index_Location_31_947534459__K1");

            entity.HasIndex(e => e.LocationId, "_dta_index_Location_7_947534459__K1_3_4_7");

            entity.HasIndex(e => e.LocationId, "_dta_index_Location_7_947534459__K1_3_7");

            entity.HasIndex(e => e.LocationId, "_dta_index_Location_7_947534459__K1_7");

            entity.HasIndex(e => e.ParentLocationId, "_dta_index_Location_7_947534459__K2");

            entity.HasIndex(e => e.ParentLocationId, "_dta_index_Location_7_947534459__K2_1_3_7");

            entity.HasIndex(e => new { e.LocationTypeId, e.LocationId }, "_dta_index_Location_7_947534459__K4_K1_2_3_5_7");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.AreaId)
                .HasMaxLength(50)
                .HasColumnName("AreaID");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LevelNodeCode).HasMaxLength(50);
            entity.Property(e => e.LocationTypeId).HasColumnName("LocationTypeID");
            entity.Property(e => e.ParentLocationId).HasColumnName("ParentLocationID");
            entity.Property(e => e.RefCode).HasMaxLength(50);
            entity.Property(e => e.RefId).HasColumnName("RefID");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.LocationAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Location_SystemTransaction");

            entity.HasOne(d => d.LocationType).WithMany(p => p.Locations)
                .HasForeignKey(d => d.LocationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Locations_LTLocationTypes");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.LocationUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_Location_SystemTransaction1");
        });

        modelBuilder.Entity<LocationArea>(entity =>
        {
            entity.HasKey(e => e.AreaId);

            entity.ToTable("LocationArea");

            entity.Property(e => e.AreaId)
                .HasMaxLength(50)
                .HasColumnName("AreaID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.AreaName).HasMaxLength(50);
        });

        modelBuilder.Entity<LocationDoor>(entity =>
        {
            entity.HasKey(e => e.DoorId).HasName("PK_LocationDoors");

            entity.ToTable("LocationDoor");

            entity.Property(e => e.DoorId).HasColumnName("DoorID");
            entity.Property(e => e.DoorIrid)
                .HasMaxLength(50)
                .HasColumnName("DoorIRID");
            entity.Property(e => e.DoorIrtagId)
                .HasMaxLength(50)
                .HasColumnName("DoorIRTagID");
            entity.Property(e => e.DoorPaincTagId)
                .HasMaxLength(50)
                .HasColumnName("DoorPaincTagID");
            entity.Property(e => e.DoorTagId)
                .HasMaxLength(50)
                .HasColumnName("DoorTagID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.HasOne(d => d.Location).WithMany(p => p.LocationDoors)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationDoors_Locations");
        });

        modelBuilder.Entity<LocationDoorArmingTime>(entity =>
        {
            entity.HasKey(e => e.DoorArmingId).HasName("PK_LocationDoorArmingTimes");

            entity.ToTable("LocationDoorArmingTime");

            entity.Property(e => e.DoorArmingId).HasColumnName("DoorArmingID");
            entity.Property(e => e.DoorId).HasColumnName("DoorID");

            entity.HasOne(d => d.Door).WithMany(p => p.LocationDoorArmingTimes)
                .HasForeignKey(d => d.DoorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationDoorArmingTimes_LocationDoors");
        });

        modelBuilder.Entity<LocationFin>(entity =>
        {
            entity.ToTable("LocationFin");

            entity.Property(e => e.LocationFinId)
                .ValueGeneratedNever()
                .HasColumnName("LocationFinID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");

            entity.HasOne(d => d.LocationFinNavigation).WithOne(p => p.LocationFin)
                .HasForeignKey<LocationFin>(d => d.LocationFinId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationFin_Location");
        });

        modelBuilder.Entity<LocationTag>(entity =>
        {
            entity.HasKey(e => new { e.LocationTagId, e.LocationId }).HasName("PK_LocationTags");

            entity.ToTable("LocationTag");

            entity.Property(e => e.LocationTagId)
                .HasMaxLength(80)
                .HasColumnName("LocationTagID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.HasOne(d => d.Location).WithMany(p => p.LocationTags)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationTags_Locations");
        });

        modelBuilder.Entity<LtalarmCloseReason>(entity =>
        {
            entity.HasKey(e => e.AlarmCloseReasonId).HasName("PK_TicketCloseReasons");

            entity.ToTable("LTAlarmCloseReason");

            entity.Property(e => e.AlarmCloseReasonId)
                .ValueGeneratedNever()
                .HasColumnName("AlarmCloseReasonID");
            entity.Property(e => e.CreatorTypeId).HasColumnName("CreatorTypeID");

            entity.HasOne(d => d.CreatorType).WithMany(p => p.LtalarmCloseReasons)
                .HasForeignKey(d => d.CreatorTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LTAlarmCloseReason_LTCreatorType");
        });

        modelBuilder.Entity<LtalarmNotificationType>(entity =>
        {
            entity.HasKey(e => e.NotificationTypeId).HasName("PK_LTTicketAlarmTypes");

            entity.ToTable("LTAlarmNotificationType");

            entity.Property(e => e.NotificationTypeId)
                .ValueGeneratedNever()
                .HasColumnName("NotificationTypeID");
        });

        modelBuilder.Entity<LtalarmStatus>(entity =>
        {
            entity.HasKey(e => e.AlarmStatusId);

            entity.ToTable("LTAlarmStatus");

            entity.Property(e => e.AlarmStatusId)
                .ValueGeneratedNever()
                .HasColumnName("AlarmStatusID");
            entity.Property(e => e.AlarmStatusKey).HasMaxLength(50);
        });

        modelBuilder.Entity<LtalarmType>(entity =>
        {
            entity.HasKey(e => e.AlarmTypeId).HasName("PK_LTTicketTypes");

            entity.ToTable("LTAlarmType");

            entity.Property(e => e.AlarmTypeId)
                .ValueGeneratedNever()
                .HasColumnName("AlarmTypeID");
        });

        modelBuilder.Entity<LtantennaFunction>(entity =>
        {
            entity.HasKey(e => e.AntennaFunctionId);

            entity.ToTable("LTAntennaFunction");

            entity.Property(e => e.AntennaFunctionId)
                .ValueGeneratedNever()
                .HasColumnName("AntennaFunctionID");
            entity.Property(e => e.ISolisFunctionId).HasColumnName("iSolisFunctionID");
        });

        modelBuilder.Entity<LtassetForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LTAssetForms");

            entity.Property(e => e.AssetFormId).HasColumnName("AssetFormID");
        });

        modelBuilder.Entity<LtassetFormSaleType>(entity =>
        {
            entity.HasKey(e => e.AssetFormSaleTypeId);

            entity.ToTable("LTAssetFormSaleType");

            entity.Property(e => e.AssetFormSaleTypeId)
                .ValueGeneratedNever()
                .HasColumnName("AssetFormSaleTypeID");
        });

        modelBuilder.Entity<LtassetMaintenanceStatus>(entity =>
        {
            entity.HasKey(e => e.AssetMaintenanceStatusId).HasName("PK_LTAssetStatuses");

            entity.ToTable("LTAssetMaintenanceStatus");

            entity.Property(e => e.AssetMaintenanceStatusId)
                .ValueGeneratedNever()
                .HasColumnName("AssetMaintenanceStatusID");
        });

        modelBuilder.Entity<LtassetState>(entity =>
        {
            entity.HasKey(e => e.AssetStateId).HasName("PK_LTAssetStates");

            entity.ToTable("LTAssetState");

            entity.Property(e => e.AssetStateId)
                .ValueGeneratedNever()
                .HasColumnName("AssetStateID");
        });

        modelBuilder.Entity<LtassetTransferReason>(entity =>
        {
            entity.HasKey(e => e.AssetTransferReasonId);

            entity.ToTable("LTAssetTransferReason");

            entity.Property(e => e.AssetTransferReasonId)
                .ValueGeneratedNever()
                .HasColumnName("AssetTransferReasonID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsLiteValue).HasDefaultValue(true);
            entity.Property(e => e.ProccessTypeId).HasColumnName("ProccessTypeID");

            entity.HasOne(d => d.ProccessType).WithMany(p => p.LtassetTransferReasons)
                .HasForeignKey(d => d.ProccessTypeId)
                .HasConstraintName("FK_LTAssetTransferReason_LTProcessType");
        });

        modelBuilder.Entity<LtassetType>(entity =>
        {
            entity.HasKey(e => e.AssetTypeId).HasName("PK_LTAssetTypes");

            entity.ToTable("LTAssetType");

            entity.Property(e => e.AssetTypeId)
                .ValueGeneratedNever()
                .HasColumnName("AssetTypeID");
        });

        modelBuilder.Entity<LtassetUnit>(entity =>
        {
            entity.HasKey(e => e.AssetUnitId);

            entity.ToTable("LTAssetUnit");

            entity.Property(e => e.AssetUnitId)
                .ValueGeneratedNever()
                .HasColumnName("AssetUnitID");
            entity.Property(e => e.IsForWeight).HasDefaultValue(true);
        });

        modelBuilder.Entity<LtauditSessionStatus>(entity =>
        {
            entity.HasKey(e => e.AuditSessionStatusId).HasName("PK_LTAuditSessionStatuses");

            entity.ToTable("LTAuditSessionStatus");

            entity.Property(e => e.AuditSessionStatusId)
                .ValueGeneratedNever()
                .HasColumnName("AuditSessionStatusID");
        });

        modelBuilder.Entity<LtauditSessionType>(entity =>
        {
            entity.HasKey(e => e.AuditSessionTypeId).HasName("PK_LTAuditSessionTypes");

            entity.ToTable("LTAuditSessionType");

            entity.Property(e => e.AuditSessionTypeId)
                .ValueGeneratedNever()
                .HasColumnName("AuditSessionTypeID");
        });

        modelBuilder.Entity<LtbackupType>(entity =>
        {
            entity.HasKey(e => e.BackupTypeId);

            entity.ToTable("LTBackupType");

            entity.Property(e => e.BackupTypeId)
                .ValueGeneratedNever()
                .HasColumnName("BackupTypeID");
        });

        modelBuilder.Entity<LtboxTransactionType>(entity =>
        {
            entity.HasKey(e => e.BoxTransactionTypeId);

            entity.ToTable("LTBoxTransactionTypes");

            entity.Property(e => e.BoxTransactionTypeId)
                .ValueGeneratedNever()
                .HasColumnName("BoxTransactionTypeID");
            entity.Property(e => e.BoxTransactionTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<LtcameraType>(entity =>
        {
            entity.HasKey(e => e.CameraTypeId).HasName("PK_LTCameraTypes");

            entity.ToTable("LTCameraType");

            entity.Property(e => e.CameraTypeId)
                .ValueGeneratedNever()
                .HasColumnName("CameraTypeID");
            entity.Property(e => e.CameraType).HasMaxLength(150);
        });

        modelBuilder.Entity<Ltcolor>(entity =>
        {
            entity.HasKey(e => e.ColorId);

            entity.ToTable("LTColor");

            entity.Property(e => e.ColorId)
                .ValueGeneratedNever()
                .HasColumnName("ColorID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<LtcontainerMode>(entity =>
        {
            entity.HasKey(e => e.ContainerModeId);

            entity.ToTable("LTContainerMode");

            entity.Property(e => e.ContainerModeId)
                .ValueGeneratedNever()
                .HasColumnName("ContainerModeID");
        });

        modelBuilder.Entity<LtcreatorType>(entity =>
        {
            entity.HasKey(e => e.CreatorTypeId);

            entity.ToTable("LTCreatorType");

            entity.Property(e => e.CreatorTypeId)
                .ValueGeneratedNever()
                .HasColumnName("CreatorTypeID");
        });

        modelBuilder.Entity<LtcustomFieldsType>(entity =>
        {
            entity.HasKey(e => e.TypeId);

            entity.ToTable("LTCustomFieldsType");

            entity.Property(e => e.TypeId).ValueGeneratedNever();
            entity.Property(e => e.SystemType).HasMaxLength(50);
            entity.Property(e => e.TitleAr)
                .HasMaxLength(50)
                .HasColumnName("TitleAR");
            entity.Property(e => e.TitleEn)
                .HasMaxLength(50)
                .HasColumnName("TitleEN");
        });

        modelBuilder.Entity<LtdayName>(entity =>
        {
            entity.HasKey(e => e.DayId).HasName("PK_LTDayNames");

            entity.ToTable("LTDayName");

            entity.Property(e => e.DayId)
                .ValueGeneratedNever()
                .HasColumnName("DayID");
        });

        modelBuilder.Entity<LtdestructionType>(entity =>
        {
            entity.HasKey(e => e.DestructionTypeId).HasName("PK_LTDestructionReason");

            entity.ToTable("LTDestructionType");

            entity.Property(e => e.DestructionTypeId)
                .ValueGeneratedNever()
                .HasColumnName("DestructionTypeID");
        });

        modelBuilder.Entity<LtformProcessState>(entity =>
        {
            entity.HasKey(e => e.FormProcessStateId).HasName("PK_LTProcessedFormStatus");

            entity.ToTable("LTFormProcessState");

            entity.Property(e => e.FormProcessStateId)
                .ValueGeneratedNever()
                .HasColumnName("FormProcessStateID");
        });

        modelBuilder.Entity<LtformType>(entity =>
        {
            entity.HasKey(e => e.FormTypeId);

            entity.ToTable("LTFormType");

            entity.Property(e => e.FormTypeId)
                .ValueGeneratedNever()
                .HasColumnName("FormTypeID");
        });

        modelBuilder.Entity<LthardwareConnectionState>(entity =>
        {
            entity.HasKey(e => e.ConnectionStateId);

            entity.ToTable("LTHardwareConnectionState");

            entity.Property(e => e.ConnectionStateId)
                .ValueGeneratedNever()
                .HasColumnName("ConnectionStateID");
        });

        modelBuilder.Entity<LthardwareModel>(entity =>
        {
            entity.HasKey(e => e.HardwareModelId).HasName("PK_LT_ReaderModel");

            entity.ToTable("LTHardwareModel");

            entity.Property(e => e.HardwareModelId)
                .ValueGeneratedNever()
                .HasColumnName("HardwareModelID");
            entity.Property(e => e.HardwareModelName).HasMaxLength(50);
            entity.Property(e => e.HardwareTypeId).HasColumnName("HardwareTypeID");

            entity.HasOne(d => d.HardwareType).WithMany(p => p.LthardwareModels)
                .HasForeignKey(d => d.HardwareTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LTHardwareModel_LTHardwareType");
        });

        modelBuilder.Entity<LthardwareType>(entity =>
        {
            entity.HasKey(e => e.HardwareTypeId).HasName("PK_HardwareTypes");

            entity.ToTable("LTHardwareType");

            entity.Property(e => e.HardwareTypeId)
                .ValueGeneratedNever()
                .HasColumnName("HardwareTypeID");
            entity.Property(e => e.HardwareType).HasMaxLength(50);
        });

        modelBuilder.Entity<Ltlanguage>(entity =>
        {
            entity.HasKey(e => e.LanguageId).HasName("PK_Languages");

            entity.ToTable("LTLanguage");

            entity.Property(e => e.LanguageId)
                .ValueGeneratedNever()
                .HasColumnName("LanguageID");
            entity.Property(e => e.LanguageCode).HasMaxLength(50);
            entity.Property(e => e.LanguageNativeName).HasMaxLength(50);
        });

        modelBuilder.Entity<LtlocationType>(entity =>
        {
            entity.HasKey(e => e.LocationTypeId).HasName("PK_LocationTypes");

            entity.ToTable("LTLocationType");

            entity.Property(e => e.LocationTypeId)
                .ValueGeneratedNever()
                .HasColumnName("LocationTypeID");
        });

        modelBuilder.Entity<LtmaintenanceType>(entity =>
        {
            entity.HasKey(e => e.MaintenanceTypeId);

            entity.ToTable("LTMaintenanceType");

            entity.Property(e => e.MaintenanceTypeId)
                .ValueGeneratedNever()
                .HasColumnName("MaintenanceTypeID");
            entity.Property(e => e.MaintenanceTypeName).HasMaxLength(25);
        });

        modelBuilder.Entity<LtpassiveReaderSearchMode>(entity =>
        {
            entity.HasKey(e => e.SearchModeId);

            entity.ToTable("LTPassiveReaderSearchMode");

            entity.Property(e => e.SearchModeId)
                .ValueGeneratedNever()
                .HasColumnName("SearchModeID");
        });

        modelBuilder.Entity<LtpaymentMethod>(entity =>
        {
            entity.HasKey(e => e.PaymentMethodId);

            entity.ToTable("LTPaymentMethod");

            entity.Property(e => e.PaymentMethodId)
                .ValueGeneratedNever()
                .HasColumnName("PaymentMethodID");
            entity.Property(e => e.CostLevel12).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostPercentageLevel1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<Ltperioritie>(entity =>
        {
            entity.HasKey(e => e.PeriorityId).HasName("PK_LTPeriorities");

            entity.ToTable("LTPerioritie");

            entity.Property(e => e.PeriorityId)
                .ValueGeneratedNever()
                .HasColumnName("PeriorityID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<LtprocessState>(entity =>
        {
            entity.HasKey(e => e.ProcessStatusId).HasName("PK_LTProcessStatus");

            entity.ToTable("LTProcessState");

            entity.Property(e => e.ProcessStatusId)
                .ValueGeneratedNever()
                .HasColumnName("ProcessStatusID");
        });

        modelBuilder.Entity<LtprocessType>(entity =>
        {
            entity.HasKey(e => e.ProcessTypeId);

            entity.ToTable("LTProcessType");

            entity.Property(e => e.ProcessTypeId)
                .ValueGeneratedNever()
                .HasColumnName("ProcessTypeID");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

            entity.HasOne(d => d.Service).WithMany(p => p.LtprocessTypes)
                .HasForeignKey(d => d.ServiceId)
                .HasConstraintName("FK_LTProcessType_SystemService");
        });

        modelBuilder.Entity<LtprocessUserAction>(entity =>
        {
            entity.HasKey(e => e.ProcessUserActionId);

            entity.ToTable("LTProcessUserAction");

            entity.Property(e => e.ProcessUserActionId)
                .ValueGeneratedNever()
                .HasColumnName("ProcessUserActionID");
        });

        modelBuilder.Entity<LtreaderFunction>(entity =>
        {
            entity.HasKey(e => e.ReaderFunctionId).HasName("PK_LTReaderTypes");

            entity.ToTable("LTReaderFunction");

            entity.Property(e => e.ReaderFunctionId)
                .ValueGeneratedNever()
                .HasColumnName("ReaderFunctionID");
            entity.Property(e => e.HardwareTypeId).HasColumnName("HardwareTypeID");
            entity.Property(e => e.ISolisFunctionId).HasColumnName("iSolisFunctionID");

            entity.HasOne(d => d.HardwareType).WithMany(p => p.LtreaderFunctions)
                .HasForeignKey(d => d.HardwareTypeId)
                .HasConstraintName("FK_LTReaderFunction_LTHardwareType");
        });

        modelBuilder.Entity<LtrelayPort>(entity =>
        {
            entity.HasKey(e => e.RelayPortId).HasName("PK_LT_RelayPort");

            entity.ToTable("LTRelayPort");

            entity.Property(e => e.RelayPortId)
                .ValueGeneratedNever()
                .HasColumnName("RelayPortID");
            entity.Property(e => e.RelayIod).HasColumnName("RelayIOD");
        });

        modelBuilder.Entity<LtrfidtagType>(entity =>
        {
            entity.HasKey(e => e.TagTypeId).HasName("PK_LTRFIDTagTypes");

            entity.ToTable("LTRFIDTagType");

            entity.Property(e => e.TagTypeId)
                .ValueGeneratedNever()
                .HasColumnName("TagTypeID");
        });

        modelBuilder.Entity<LtsaleCancelReason>(entity =>
        {
            entity.HasKey(e => e.SalCancelReason);

            entity.ToTable("LTSaleCancelReason");

            entity.Property(e => e.SalCancelReason).ValueGeneratedNever();
        });

        modelBuilder.Entity<LtsystemAppType>(entity =>
        {
            entity.HasKey(e => e.SystemAppTypeId);

            entity.ToTable("LTSystemAppType");

            entity.Property(e => e.SystemAppTypeId)
                .ValueGeneratedNever()
                .HasColumnName("SystemAppTypeID");
            entity.Property(e => e.SystemAppKey).HasMaxLength(50);
        });

        modelBuilder.Entity<LtsystemEntity>(entity =>
        {
            entity.HasKey(e => e.EntityId);

            entity.ToTable("LTSystemEntities");

            entity.Property(e => e.EntityId)
                .ValueGeneratedNever()
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(50);
        });

        modelBuilder.Entity<MissingAsset>(entity =>
        {
            entity.HasKey(e => e.MissingAssetId).HasName("PK_MissingAssets");

            entity.ToTable("MissingAsset");

            entity.Property(e => e.MissingAssetId).HasColumnName("MissingAssetID");
            entity.Property(e => e.AddDate).HasColumnType("datetime");
            entity.Property(e => e.AddUserId).HasColumnName("AddUserID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.MissingDate).HasColumnType("datetime");
            entity.Property(e => e.ModfiyDate).HasColumnType("datetime");
            entity.Property(e => e.ModfiyUserId).HasColumnName("ModfiyUserID");

            entity.HasOne(d => d.AddUser).WithMany(p => p.MissingAssetAddUsers)
                .HasForeignKey(d => d.AddUserId)
                .HasConstraintName("FK_MissingAssets_Users");

            entity.HasOne(d => d.Asset).WithMany(p => p.MissingAssets)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MissingAssets_Assets");

            entity.HasOne(d => d.ModfiyUser).WithMany(p => p.MissingAssetModfiyUsers)
                .HasForeignKey(d => d.ModfiyUserId)
                .HasConstraintName("FK_MissingAssets_Users1");
        });

        modelBuilder.Entity<MissingGeofencedAsset>(entity =>
        {
            entity.HasKey(e => e.MissingGeofencedAssetId).HasName("PK_MissingGeofencedAssets");

            entity.ToTable("MissingGeofencedAsset");

            entity.Property(e => e.MissingGeofencedAssetId).HasColumnName("MissingGeofencedAssetID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AuditSessionId).HasColumnName("AuditSessionID");
            entity.Property(e => e.GeofencedLocationId).HasColumnName("GeofencedLocationID");
            entity.Property(e => e.MissingDate).HasColumnType("datetime");

            entity.HasOne(d => d.Asset).WithMany(p => p.MissingGeofencedAssets)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MissingGeofencedAssets_Assets");

            entity.HasOne(d => d.GeofencedLocation).WithMany(p => p.MissingGeofencedAssets)
                .HasForeignKey(d => d.GeofencedLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MissingGeofencedAssets_Locations");
        });

        modelBuilder.Entity<ParpareDepreciationView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ParpareDepreciationView");

            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.BeginDate).HasColumnType("datetime");
            entity.Property(e => e.CurrentPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DepreciationPlanId).HasColumnName("DepreciationPlanID");
            entity.Property(e => e.FirstPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PendingAssetRegistrationForm>(entity =>
        {
            entity.ToTable("PendingAssetRegistrationForm");

            entity.Property(e => e.PendingAssetRegistrationFormId).HasColumnName("PendingAssetRegistrationFormID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.GurdianshipFormId).HasColumnName("GurdianshipFormID");
            entity.Property(e => e.RefrenceNo).HasMaxLength(50);
            entity.Property(e => e.RequestLocationId).HasColumnName("RequestLocationID");
        });

        modelBuilder.Entity<PredefindTag>(entity =>
        {
            entity.ToTable("PredefindTag");

            entity.Property(e => e.PredefindTagId).HasColumnName("PredefindTagID");
            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.TagId)
                .HasMaxLength(50)
                .HasColumnName("TagID");
            entity.Property(e => e.TagTypeId).HasColumnName("TagTypeID");
            entity.Property(e => e.Tid).HasColumnName("TID");
        });

        modelBuilder.Entity<ProcessedAssetForm>(entity =>
        {
            entity.ToTable("ProcessedAssetForm");

            entity.Property(e => e.ProcessedAssetFormId).HasColumnName("ProcessedAssetFormID");
            entity.Property(e => e.AssetFormId).HasColumnName("AssetFormID");
            entity.Property(e => e.FormDate).HasColumnType("datetime");
            entity.Property(e => e.ProccessTypeId).HasColumnName("ProccessTypeID");
            entity.Property(e => e.ProcessedAssetFormParentId).HasColumnName("ProcessedAssetFormParentID");
            entity.Property(e => e.ProcessedFormStatusId)
                .HasDefaultValue(1)
                .HasColumnName("ProcessedFormStatusID");
            entity.Property(e => e.ReportUrl).HasColumnName("ReportURL");

            entity.HasOne(d => d.ProccessType).WithMany(p => p.ProcessedAssetForms)
                .HasForeignKey(d => d.ProccessTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProcessedAssetForm_LTProcessType");

            entity.HasOne(d => d.ProcessedAssetFormParent).WithMany(p => p.InverseProcessedAssetFormParent)
                .HasForeignKey(d => d.ProcessedAssetFormParentId)
                .HasConstraintName("FK_ProcessedAssetForm_ProcessedAssetForm");

            entity.HasOne(d => d.ProcessedByNavigation).WithMany(p => p.ProcessedAssetForms)
                .HasForeignKey(d => d.ProcessedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProcessedAssetForm_UserAccount");

            entity.HasOne(d => d.ProcessedFormStatus).WithMany(p => p.ProcessedAssetForms)
                .HasForeignKey(d => d.ProcessedFormStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProcessedAssetForm_LTProcessedFormStatus");
        });

        modelBuilder.Entity<ProcessedAssetFormLog>(entity =>
        {
            entity.HasKey(e => e.ProcessedAssetFormLog1);

            entity.ToTable("ProcessedAssetFormLog");

            entity.Property(e => e.ProcessedAssetFormLog1).HasColumnName("ProcessedAssetFormLog");
            entity.Property(e => e.FormDate).HasColumnType("datetime");
            entity.Property(e => e.ProcessedAssetFormId).HasColumnName("ProcessedAssetFormID");
            entity.Property(e => e.ProcessedFormStatusId)
                .HasDefaultValue(1)
                .HasColumnName("ProcessedFormStatusID");

            entity.HasOne(d => d.ProcessedAssetForm).WithMany(p => p.ProcessedAssetFormLogs)
                .HasForeignKey(d => d.ProcessedAssetFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProcessedAssetFormLog_ProcessedAssetForm");

            entity.HasOne(d => d.ProcessedByNavigation).WithMany(p => p.ProcessedAssetFormLogs)
                .HasForeignKey(d => d.ProcessedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProcessedAssetFormLog_UserAccount");
        });

        modelBuilder.Entity<ReportInfo>(entity =>
        {
            entity.HasKey(e => e.ReportId);

            entity.ToTable("ReportInfo");

            entity.Property(e => e.ReportId).HasColumnName("ReportID");
            entity.Property(e => e.ReportAppLogo).HasMaxLength(50);
            entity.Property(e => e.ReportCustomerLogo).HasMaxLength(50);
            entity.Property(e => e.ReportName).HasMaxLength(50);
        });

        modelBuilder.Entity<RfidactiveReader>(entity =>
        {
            entity.HasKey(e => e.HardwareId).HasName("PK_ActiveRFIDReaders");

            entity.ToTable("RFIDActiveReader");

            entity.Property(e => e.HardwareId)
                .ValueGeneratedNever()
                .HasColumnName("HardwareID");
            entity.Property(e => e.Attenuation).HasDefaultValue(8);
            entity.Property(e => e.ChannelAthreshold)
                .HasDefaultValue(110)
                .HasColumnName("ChannelAThreshold");
            entity.Property(e => e.ChannelBthreshold)
                .HasDefaultValue(110)
                .HasColumnName("ChannelBThreshold");
            entity.Property(e => e.NoOfTriesToConnectB4disabling)
                .HasDefaultValue(72)
                .HasColumnName("NoOfTriesToConnectB4Disabling");
            entity.Property(e => e.ReaderTypeId).HasColumnName("ReaderTypeID");
            entity.Property(e => e.ReceiveTimeout).HasDefaultValue(500);
            entity.Property(e => e.SendTimeout).HasDefaultValue(500);
            entity.Property(e => e.TimeB4tryToConnect)
                .HasDefaultValue(60000)
                .HasColumnName("TimeB4TryToConnect");

            entity.HasOne(d => d.Hardware).WithOne(p => p.RfidactiveReader)
                .HasForeignKey<RfidactiveReader>(d => d.HardwareId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFIDReaders_Hardware");

            entity.HasOne(d => d.ReaderType).WithMany(p => p.RfidactiveReaders)
                .HasForeignKey(d => d.ReaderTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFIDReaders_LTReaderTypes");
        });

        modelBuilder.Entity<Rfidantenna>(entity =>
        {
            entity.HasKey(e => e.AntennaId).HasName("PK_Antenna");

            entity.ToTable("RFIDAntenna");

            entity.Property(e => e.AntennaId).HasColumnName("AntennaID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.ConnectedReaderId).HasColumnName("ConnectedReaderID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ReferenceTagId)
                .HasMaxLength(50)
                .HasColumnName("ReferenceTagID");
            entity.Property(e => e.SerailNumber).HasMaxLength(50);
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.RfidantennaAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFIDAntenna_SystemTransaction");

            entity.HasOne(d => d.AntennaFunctionNavigation).WithMany(p => p.Rfidantennas)
                .HasForeignKey(d => d.AntennaFunction)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFIDAntenna_LTAntennaFunction");

            entity.HasOne(d => d.ConnectedReader).WithMany(p => p.Rfidantennas)
                .HasForeignKey(d => d.ConnectedReaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFIDAntenna_RFIDPassiveReader");

            entity.HasOne(d => d.Location).WithMany(p => p.Rfidantennas)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFIDAntenna_Locations");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.RfidantennaUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_RFIDAntenna_SystemTransaction1");
        });

        modelBuilder.Entity<Rfidcamera>(entity =>
        {
            entity.HasKey(e => e.HardwareId).HasName("PK_Cameras");

            entity.ToTable("RFIDCamera");

            entity.Property(e => e.HardwareId)
                .ValueGeneratedOnAdd()
                .HasColumnName("HardwareID");
            entity.Property(e => e.CameraPassword).HasMaxLength(50);
            entity.Property(e => e.CameraTypeId).HasColumnName("CameraTypeID");
            entity.Property(e => e.CameraUsername).HasMaxLength(50);
            entity.Property(e => e.EnableMotionDetection).HasDefaultValue(false);
            entity.Property(e => e.JoinWithReaderId).HasColumnName("JoinWithReaderID");
            entity.Property(e => e.StoreLocation).HasMaxLength(50);
            entity.Property(e => e.TailTime).HasDefaultValue(0);

            entity.HasOne(d => d.CameraType).WithMany(p => p.Rfidcameras)
                .HasForeignKey(d => d.CameraTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cameras_LTCameraTypes");

            entity.HasOne(d => d.Hardware).WithOne(p => p.Rfidcamera)
                .HasForeignKey<Rfidcamera>(d => d.HardwareId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFIDCamera_Hardware");
        });

        modelBuilder.Entity<RfidhandHeld>(entity =>
        {
            entity.HasKey(e => e.HandHeldId).HasName("PK_RFIDHandHelds");

            entity.ToTable("RFIDHandHeld");

            entity.Property(e => e.HandHeldId).HasColumnName("HandHeldID");
            entity.Property(e => e.Macaddress)
                .HasMaxLength(250)
                .HasColumnName("MACAddress");
        });

        modelBuilder.Entity<RfidpassiveReader>(entity =>
        {
            entity.HasKey(e => e.HardwareId).HasName("PK_Reader");

            entity.ToTable("RFIDPassiveReader");

            entity.Property(e => e.HardwareId)
                .ValueGeneratedNever()
                .HasColumnName("HardwareID");
            entity.Property(e => e.NoOfTriesToConnectB4disabling).HasColumnName("NoOfTriesToConnectB4Disabling");
            entity.Property(e => e.ReadingSession).HasDefaultValue(1);
            entity.Property(e => e.SearchMode).HasDefaultValue(1);
            entity.Property(e => e.TimeB4tryToConnect).HasColumnName("TimeB4TryToConnect");

            entity.HasOne(d => d.Hardware).WithOne(p => p.RfidpassiveReader)
                .HasForeignKey<RfidpassiveReader>(d => d.HardwareId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFIDPassiveReader_Hardware");

            entity.HasOne(d => d.ReaderModelNavigation).WithMany(p => p.RfidpassiveReaders)
                .HasForeignKey(d => d.ReaderModel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFIDPassiveReader_LTHardwareModel");

            entity.HasOne(d => d.ReaderTypeNavigation).WithMany(p => p.RfidpassiveReaders)
                .HasForeignKey(d => d.ReaderType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFIDPassiveReader_LTReaderType");

            entity.HasOne(d => d.SearchModeNavigation).WithMany(p => p.RfidpassiveReaders)
                .HasForeignKey(d => d.SearchMode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFIDPassiveReader_LTPassiveReaderSearchMode");
        });

        modelBuilder.Entity<RfidroomLocator>(entity =>
        {
            entity.HasKey(e => e.RoomLocatorId).HasName("PK_RoomLocators");

            entity.ToTable("RFIDRoomLocator");

            entity.Property(e => e.RoomLocatorId)
                .ValueGeneratedNever()
                .HasColumnName("RoomLocatorID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.HasOne(d => d.Location).WithMany(p => p.RfidroomLocators)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoomLocators_Locations");
        });

        modelBuilder.Entity<Rfidscreen>(entity =>
        {
            entity.HasKey(e => e.HardwareId).HasName("PK_Screens");

            entity.ToTable("RFIDScreen");

            entity.Property(e => e.HardwareId)
                .ValueGeneratedNever()
                .HasColumnName("HardwareID");

            entity.HasOne(d => d.Hardware).WithOne(p => p.Rfidscreen)
                .HasForeignKey<Rfidscreen>(d => d.HardwareId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Screens_Hardware");
        });

        modelBuilder.Entity<SecurityGuard>(entity =>
        {
            entity.HasKey(e => e.GuardId).HasName("PK_SecurityGuards");

            entity.ToTable("SecurityGuard");

            entity.Property(e => e.GuardId).HasColumnName("GuardID");
            entity.Property(e => e.ContactName).HasMaxLength(150);
            entity.Property(e => e.EmailAddress).HasMaxLength(30);
            entity.Property(e => e.InformWithRfidreaderStatus).HasColumnName("InformWithRFIDReaderStatus");
            entity.Property(e => e.MobileNumber).HasMaxLength(15);
            entity.Property(e => e.ShouldContactViaSms).HasColumnName("ShouldContactViaSMS");

            entity.HasMany(d => d.Locations).WithMany(p => p.Guards)
                .UsingEntity<Dictionary<string, object>>(
                    "SecurityGuardLocation",
                    r => r.HasOne<Location>().WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SecurityGuardLocations_SecurityGuards"),
                    l => l.HasOne<SecurityGuard>().WithMany()
                        .HasForeignKey("GuardId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SecurityGuardLocations_SecurityGuards1"),
                    j =>
                    {
                        j.HasKey("GuardId", "LocationId").HasName("PK_SecurityGuardLocations");
                        j.ToTable("SecurityGuardLocation");
                        j.IndexerProperty<int>("GuardId").HasColumnName("GuardID");
                        j.IndexerProperty<int>("LocationId").HasColumnName("LocationID");
                    });
        });

        modelBuilder.Entity<ServiceFunction>(entity =>
        {
            entity.HasKey(e => e.FunctionId);

            entity.ToTable("ServiceFunction");

            entity.Property(e => e.FunctionId)
                .ValueGeneratedNever()
                .HasColumnName("FunctionID");
            entity.Property(e => e.FuncationIcon).HasMaxLength(50);
            entity.Property(e => e.FuncationName).HasMaxLength(50);
        });

        modelBuilder.Entity<Siren>(entity =>
        {
            entity.HasKey(e => e.SirenId).HasName("PK_Siren_1");

            entity.ToTable("Siren");

            entity.Property(e => e.SirenId).HasColumnName("SirenID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.HardwareId).HasColumnName("HardwareID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LastAlarmTime).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.RelatedHardwareId).HasColumnName("RelatedHardwareID");
            entity.Property(e => e.RelayPortId).HasColumnName("RelayPortID");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.SirenAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Siren_AddSystemTransaction");

            entity.HasOne(d => d.Hardware).WithMany(p => p.Sirens)
                .HasForeignKey(d => d.HardwareId)
                .HasConstraintName("FK_Siren_SirenRelay");

            entity.HasOne(d => d.Location).WithMany(p => p.Sirens)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Siren_Location");

            entity.HasOne(d => d.RelatedHardware).WithMany(p => p.Sirens)
                .HasForeignKey(d => d.RelatedHardwareId)
                .HasConstraintName("FK_Siren_Hardware");

            entity.HasOne(d => d.RelayPort).WithMany(p => p.Sirens)
                .HasForeignKey(d => d.RelayPortId)
                .HasConstraintName("FK_Siren_LTRelayPort");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.SirenUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_Siren_UpdateSystemTransaction");
        });

        modelBuilder.Entity<SirenLocation>(entity =>
        {
            entity.ToTable("SirenLocation");

            entity.Property(e => e.SirenLocationId).HasColumnName("SirenLocationID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.SirenId).HasColumnName("SirenID");

            entity.HasOne(d => d.Location).WithMany(p => p.SirenLocations)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SirenLocation_Location");

            entity.HasOne(d => d.Siren).WithMany(p => p.SirenLocations)
                .HasForeignKey(d => d.SirenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SirenLocation_Siren");
        });

        modelBuilder.Entity<SirenReader>(entity =>
        {
            entity.ToTable("SirenReader");

            entity.Property(e => e.SirenReaderId).HasColumnName("SirenReaderID");
            entity.Property(e => e.ReaderId).HasColumnName("ReaderID");
            entity.Property(e => e.SirenId).HasColumnName("SirenID");

            entity.HasOne(d => d.Reader).WithMany(p => p.SirenReaders)
                .HasForeignKey(d => d.ReaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SirenReader_Hardware");

            entity.HasOne(d => d.Siren).WithMany(p => p.SirenReaders)
                .HasForeignKey(d => d.SirenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SirenReader_Siren");
        });

        modelBuilder.Entity<SirenRelay>(entity =>
        {
            entity.HasKey(e => e.HardwareId);

            entity.ToTable("SirenRelay");

            entity.Property(e => e.HardwareId)
                .ValueGeneratedNever()
                .HasColumnName("HardwareID");

            entity.HasOne(d => d.Hardware).WithOne(p => p.SirenRelay)
                .HasForeignKey<SirenRelay>(d => d.HardwareId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SirenRelay_Hardware");
        });

        modelBuilder.Entity<SirenRole>(entity =>
        {
            entity.ToTable("SirenRole");

            entity.Property(e => e.SirenRoleId).HasColumnName("SirenRoleID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.DayId).HasColumnName("DayID");
            entity.Property(e => e.SirenId).HasColumnName("SirenID");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.SirenRoleAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SirenRole_AddSystemTransaction");

            entity.HasOne(d => d.Day).WithMany(p => p.SirenRoles)
                .HasForeignKey(d => d.DayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SirenRole_LTDayName");

            entity.HasOne(d => d.Siren).WithMany(p => p.SirenRoles)
                .HasForeignKey(d => d.SirenId)
                .HasConstraintName("FK_SirenRole_Siren");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.SirenRoleUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_SirenRole_UpdateSystemTransaction");
        });

        modelBuilder.Entity<Smslog>(entity =>
        {
            entity.HasKey(e => e.Smsid);

            entity.ToTable("SMSLog");

            entity.Property(e => e.Smsid).HasColumnName("SMSID");
            entity.Property(e => e.AlarmId).HasColumnName("AlarmID");
            entity.Property(e => e.SendDate).HasColumnType("datetime");
            entity.Property(e => e.UserScheduleId).HasColumnName("UserScheduleID");

            entity.HasOne(d => d.Alarm).WithMany(p => p.Smslogs)
                .HasForeignKey(d => d.AlarmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMSLog_Alarm");

            entity.HasOne(d => d.UserSchedule).WithMany(p => p.Smslogs)
                .HasForeignKey(d => d.UserScheduleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMSLog_UserScheduleI");
        });

        modelBuilder.Entity<Switch>(entity =>
        {
            entity.HasKey(e => e.SwitchId).HasName("PK_Switches");

            entity.ToTable("Switch");

            entity.Property(e => e.SwitchId).HasColumnName("SwitchID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.SwitchIp).HasColumnName("SwitchIP");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.SwitchAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Switche_SystemTransactionAdd");

            entity.HasOne(d => d.Location).WithMany(p => p.Switches)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Switche_Location");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.SwitchUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_Switche_SystemTransactionUpdate");
        });

        modelBuilder.Entity<SystemAlarmRole>(entity =>
        {
            entity.ToTable("SystemAlarmRole");

            entity.Property(e => e.SystemAlarmRoleId)
                .ValueGeneratedNever()
                .HasColumnName("SystemAlarmRoleID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.AlarmIfgatePass).HasColumnName("AlarmIFGatePass");
            entity.Property(e => e.AlarmIflost).HasColumnName("AlarmIFLost");
            entity.Property(e => e.AlarmIfmotion).HasColumnName("AlarmIFMotion");
            entity.Property(e => e.AlarmIfnearstReaderChange).HasColumnName("AlarmIFNearstReaderChange");
            entity.Property(e => e.AlarmIfnotDetected).HasColumnName("AlarmIFNotDetected");
            entity.Property(e => e.AlarmIfpanic).HasColumnName("AlarmIFPanic");
            entity.Property(e => e.AlarmIfroomLocatorChange).HasColumnName("AlarmIFRoomLocatorChange");
            entity.Property(e => e.AlarmIftamper).HasColumnName("AlarmIFTamper");
            entity.Property(e => e.AlarmIfunAuthZonePass).HasColumnName("AlarmIFUnAuthZonePass");
            entity.Property(e => e.AlarmIfunCovered).HasColumnName("AlarmIFUnCovered");
            entity.Property(e => e.AlarmIfzoneChange).HasColumnName("AlarmIFZoneChange");
            entity.Property(e => e.RepeatAlarmIfgatePass).HasColumnName("RepeatAlarmIFGatePass");
            entity.Property(e => e.RepeatAlarmIfnearstReaderChange).HasColumnName("RepeatAlarmIFNearstReaderChange");
            entity.Property(e => e.RepeatAlarmIfroomLocatorChange).HasColumnName("RepeatAlarmIFRoomLocatorChange");
            entity.Property(e => e.RepeatAlarmIfunAuthZonePass).HasColumnName("RepeatAlarmIFUnAuthZonePass");
            entity.Property(e => e.RepeatAlarmIfzoneChange).HasColumnName("RepeatAlarmIFZoneChange");
            entity.Property(e => e.SirenOnLocationChange).HasDefaultValue(true);
            entity.Property(e => e.SystemRunningMode).HasDefaultValue(1);
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.SystemAlarmRoleAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SystemAlarmRole_AddSystemTransaction");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.SystemAlarmRoleUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_SystemAlarmRole_UpdateSystemTransaction");
        });

        modelBuilder.Entity<SystemApp>(entity =>
        {
            entity.HasKey(e => e.SystemAppId).HasName("PK_Handheld");

            entity.Property(e => e.SystemAppId).HasColumnName("SystemAppID");
            entity.Property(e => e.AppTypeId).HasColumnName("AppTypeID");
            entity.Property(e => e.LicenseId).HasColumnName("LicenseID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.RegisterDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.AppType).WithMany(p => p.SystemApps)
                .HasForeignKey(d => d.AppTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SystemApps_LTSystemAppType");

            entity.HasOne(d => d.License).WithMany(p => p.SystemApps)
                .HasForeignKey(d => d.LicenseId)
                .HasConstraintName("FK_Handheld_License");

            entity.HasOne(d => d.Location).WithMany(p => p.SystemApps)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_SystemApps_Location");
        });

        modelBuilder.Entity<SystemAssetStateRule>(entity =>
        {
            entity.HasKey(e => new { e.CuurentStateId, e.AllowedNewStateId });

            entity.ToTable("SystemAssetStateRule");

            entity.Property(e => e.CuurentStateId).HasColumnName("CuurentStateID");
            entity.Property(e => e.AllowedNewStateId).HasColumnName("AllowedNewStateID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");

            entity.HasOne(d => d.AllowedNewState).WithMany(p => p.SystemAssetStateRuleAllowedNewStates)
                .HasForeignKey(d => d.AllowedNewStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SystemAssetStateRule_LTAssetState1");

            entity.HasOne(d => d.CuurentState).WithMany(p => p.SystemAssetStateRuleCuurentStates)
                .HasForeignKey(d => d.CuurentStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SystemAssetStateRule_LTAssetState");
        });

        modelBuilder.Entity<SystemBugsLog>(entity =>
        {
            entity.HasKey(e => e.BugLogId);

            entity.ToTable("SystemBugsLog");

            entity.Property(e => e.BugLogId).HasColumnName("BugLogID");
            entity.Property(e => e.BugDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Message).HasDefaultValue("Undefined Message");
            entity.Property(e => e.Recived).HasDefaultValue(false);
            entity.Property(e => e.Source).HasDefaultValue("Undefined Source");
            entity.Property(e => e.UserId)
                .HasDefaultValue(0)
                .HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.SystemBugsLogs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_SystemBugsLog_Users");
        });

        modelBuilder.Entity<SystemConfig>(entity =>
        {
            entity.HasKey(e => e.SystemKeyId).HasName("PK_SystemKey");

            entity.ToTable("SystemConfig");

            entity.Property(e => e.SystemKeyId)
                .ValueGeneratedNever()
                .HasColumnName("SystemKeyID");
            entity.Property(e => e.SystemKeyCode)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<SystemCore>(entity =>
        {
            entity.HasKey(e => e.CoreId).HasName("PK_SystemServer");

            entity.ToTable("SystemCore");

            entity.Property(e => e.CoreId).HasColumnName("CoreID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.CoreIp)
                .HasMaxLength(50)
                .HasColumnName("CoreIP");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsConnected).HasDefaultValue(true);
            entity.Property(e => e.LicenseId).HasColumnName("LicenseID");
            entity.Property(e => e.RegisterDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");
            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.SystemCoreAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SystemCore_SystemTransaction");

            entity.HasOne(d => d.License).WithMany(p => p.SystemCores)
                .HasForeignKey(d => d.LicenseId)
                .HasConstraintName("FK_SystemCore_License");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.SystemCoreUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_SystemCore_SystemTransactionUpdate");

            entity.HasOne(d => d.Zone).WithMany(p => p.SystemCores)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("FK_SystemCore_Zone");
        });

        modelBuilder.Entity<SystemCoreTransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId);

            entity.ToTable("SystemCoreTransaction");

            entity.Property(e => e.TransactionId)
                .ValueGeneratedNever()
                .HasColumnName("TransactionID");
            entity.Property(e => e.SystemIp).HasColumnName("SystemIP");
            entity.Property(e => e.TransactionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TransactionType).HasDefaultValue(0);
        });

        modelBuilder.Entity<SystemService>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK_MainMenu");

            entity.ToTable("SystemService");

            entity.Property(e => e.ServiceId)
                .ValueGeneratedNever()
                .HasColumnName("ServiceID");
            entity.Property(e => e.ControllerName).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsActiveForPrivalage).HasDefaultValue(true);
            entity.Property(e => e.IsMenuItem).HasDefaultValue(true);
            entity.Property(e => e.ParentServiceId).HasColumnName("ParentServiceID");
            entity.Property(e => e.ServiceGroupId).HasColumnName("ServiceGroupID");
            entity.Property(e => e.Shortcut).HasMaxLength(100);
        });

        modelBuilder.Entity<SystemSetting>(entity =>
        {
            entity.ToTable("SystemSetting");

            entity.Property(e => e.SystemSettingId)
                .ValueGeneratedNever()
                .HasColumnName("SystemSettingID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.ProxyUrl).HasColumnName("ProxyURL");
            entity.Property(e => e.Smspass).HasColumnName("SMSPass");
            entity.Property(e => e.SmsrequestUrl).HasColumnName("SMSRequestURL");
            entity.Property(e => e.Smsuser).HasColumnName("SMSUser");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.SystemSettings)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SystemSetting_SystemTransaction");
        });

        modelBuilder.Entity<SystemTagFilter>(entity =>
        {
            entity.HasKey(e => e.TagFilterId);

            entity.ToTable("SystemTagFilter");

            entity.Property(e => e.TagFilterId).HasColumnName("TagFilterID");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SystemTransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId);

            entity.ToTable("SystemTransaction");

            entity.Property(e => e.TransactionId)
                .ValueGeneratedNever()
                .HasColumnName("TransactionID");
            entity.Property(e => e.TransactionByUserId).HasColumnName("TransactionByUserID");
            entity.Property(e => e.TransactionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.TransactionByUser).WithMany(p => p.SystemTransactions)
                .HasForeignKey(d => d.TransactionByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SystemTransactions_Users");
        });

        modelBuilder.Entity<TaskRole>(entity =>
        {
            entity.ToTable("TaskRole");

            entity.Property(e => e.TaskRoleId)
                .ValueGeneratedNever()
                .HasColumnName("TaskRoleID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
        });

        modelBuilder.Entity<TaskRoleProcess>(entity =>
        {
            entity.ToTable("TaskRoleProcess");

            entity.Property(e => e.TaskRoleProcessId)
                .ValueGeneratedNever()
                .HasColumnName("TaskRoleProcessID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.NextTaskRoleId).HasColumnName("NextTaskRoleID");
            entity.Property(e => e.ProcessTypeId).HasColumnName("ProcessTypeID");
            entity.Property(e => e.TaskRoleId).HasColumnName("TaskRoleID");

            entity.HasOne(d => d.NextTaskRole).WithMany(p => p.TaskRoleProcessNextTaskRoles)
                .HasForeignKey(d => d.NextTaskRoleId)
                .HasConstraintName("FK_TaskRoleProcess_NextTaskRole");

            entity.HasOne(d => d.TaskRole).WithMany(p => p.TaskRoleProcessTaskRoles)
                .HasForeignKey(d => d.TaskRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskRoleProcess_TaskRole");
        });

        modelBuilder.Entity<Temp2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Temp2");

            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.ClassCode).HasMaxLength(50);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassId2).HasColumnName("ClassID2");
            entity.Property(e => e.ClassImage).HasMaxLength(100);
            entity.Property(e => e.ClassLevelId).HasColumnName("ClassLevelID");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LevelNodeCode).HasMaxLength(50);
            entity.Property(e => e.ParentClassId).HasColumnName("ParentClassID");
            entity.Property(e => e.RefId).HasColumnName("RefID");
            entity.Property(e => e.TagId)
                .HasMaxLength(50)
                .HasColumnName("TagID");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");
        });

        modelBuilder.Entity<Temp3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Temp3");

            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetId2).HasColumnName("AssetID2");
            entity.Property(e => e.ClassCode).HasMaxLength(50);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassId2).HasColumnName("ClassID2");
            entity.Property(e => e.ClassImage).HasMaxLength(100);
            entity.Property(e => e.ClassLevelId).HasColumnName("ClassLevelID");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LevelNodeCode).HasMaxLength(50);
            entity.Property(e => e.ParentClassId).HasColumnName("ParentClassID");
            entity.Property(e => e.RefId).HasColumnName("RefID");
            entity.Property(e => e.TagId)
                .HasMaxLength(50)
                .HasColumnName("TagID");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");
        });

        modelBuilder.Entity<Temp4>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Temp4");

            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.AreaId)
                .HasMaxLength(50)
                .HasColumnName("AreaID");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LevelNodeCode).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LocationTypeId).HasColumnName("LocationTypeID");
            entity.Property(e => e.ParentLocationId).HasColumnName("ParentLocationID");
            entity.Property(e => e.RefCode).HasMaxLength(50);
            entity.Property(e => e.RefId).HasColumnName("RefID");
            entity.Property(e => e.TypeId3).HasColumnName("TypeID3");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");
        });

        modelBuilder.Entity<Temp5>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Temp5");

            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetId2).HasColumnName("AssetID2");
            entity.Property(e => e.FieldValue).HasMaxLength(100);
            entity.Property(e => e.IsPrivate).HasMaxLength(50);
            entity.Property(e => e.TagId)
                .HasMaxLength(50)
                .HasColumnName("TagID");
            entity.Property(e => e.TitleAr)
                .HasMaxLength(100)
                .HasColumnName("TitleAR");
            entity.Property(e => e.TitleEn)
                .HasMaxLength(100)
                .HasColumnName("TitleEN");
        });

        modelBuilder.Entity<Temp6>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Temp6");

            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetId2).HasColumnName("AssetID2");
            entity.Property(e => e.AssetId3).HasColumnName("AssetID3");
            entity.Property(e => e.FieldValue).HasMaxLength(100);
            entity.Property(e => e.IsPrivate).HasMaxLength(50);
            entity.Property(e => e.TagId)
                .HasMaxLength(50)
                .HasColumnName("TagID");
            entity.Property(e => e.TitleAr)
                .HasMaxLength(100)
                .HasColumnName("TitleAR");
            entity.Property(e => e.TitleEn)
                .HasMaxLength(100)
                .HasColumnName("TitleEN");
        });

        modelBuilder.Entity<TempAssetEditTag>(entity =>
        {
            entity.ToTable("TempAssetEditTag");

            entity.Property(e => e.TempAssetEditTagId).HasColumnName("TempAssetEditTagID");
            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            entity.Property(e => e.TagId)
                .HasMaxLength(50)
                .HasColumnName("TagID");
            entity.Property(e => e.TagTypeId).HasColumnName("TagTypeID");

            entity.HasOne(d => d.Process).WithMany(p => p.TempAssetEditTags)
                .HasForeignKey(d => d.ProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempAssetEditTag_TempProcessEditItems");

            entity.HasOne(d => d.TagType).WithMany(p => p.TempAssetEditTags)
                .HasForeignKey(d => d.TagTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempAssetEditTag_TempAssetEditTag");
        });

        modelBuilder.Entity<TempAssetTag>(entity =>
        {
            entity.ToTable("TempAssetTag");

            entity.HasIndex(e => e.TempAssetTagId, "IX_TempAssetTag").IsUnique();

            entity.Property(e => e.TempAssetTagId).HasColumnName("TempAssetTagID");
            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            entity.Property(e => e.TagId)
                .HasMaxLength(50)
                .HasColumnName("TagID");
            entity.Property(e => e.TagTypeId).HasColumnName("TagTypeID");
            entity.Property(e => e.Tid).HasColumnName("TID");

            entity.HasOne(d => d.Process).WithMany(p => p.TempAssetTags)
                .HasForeignKey(d => d.ProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempAssetTag_TempProcessRegistrationItem");

            entity.HasOne(d => d.TagType).WithMany(p => p.TempAssetTags)
                .HasForeignKey(d => d.TagTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempAssetTag_LTRFIDTagType");
        });

        modelBuilder.Entity<TempDatum>(entity =>
        {
            entity.HasKey(e => e.TempDataId);

            entity.Property(e => e.TempDataId)
                .ValueGeneratedNever()
                .HasColumnName("TempDataID");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TempProcess>(entity =>
        {
            entity.HasKey(e => e.TempProcessId).HasName("PK_TempAssetProcess");

            entity.ToTable("TempProcess");

            entity.Property(e => e.TempProcessId).HasColumnName("TempProcessID");
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.WarehouseFormId).HasColumnName("WarehouseFormID");

            entity.HasOne(d => d.AddedByNavigation).WithMany(p => p.TempProcessAddedByNavigations)
                .HasForeignKey(d => d.AddedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempAssetProcess_UserAccount");

            entity.HasOne(d => d.ProcessStatusNavigation).WithMany(p => p.TempProcesses)
                .HasForeignKey(d => d.ProcessStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcess_LTProcessStatus");

            entity.HasOne(d => d.ProcessTypeNavigation).WithMany(p => p.TempProcesses)
                .HasForeignKey(d => d.ProcessType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempAssetProcess_LTProcessType");

            entity.HasOne(d => d.TakenByNavigation).WithMany(p => p.TempProcessTakenByNavigations)
                .HasForeignKey(d => d.TakenBy)
                .HasConstraintName("FK_TempProcess_UserAccount_RunningBy");

            entity.HasOne(d => d.WarehouseForm).WithMany(p => p.TempProcesses)
                .HasForeignKey(d => d.WarehouseFormId)
                .HasConstraintName("FK_TempProcess_AssetForm");
        });

        modelBuilder.Entity<TempProcessCustomFieldDatum>(entity =>
        {
            entity.HasKey(e => e.TempValueId);

            entity.Property(e => e.FieldValue).HasMaxLength(50);
            entity.Property(e => e.TitleAr)
                .HasMaxLength(50)
                .HasColumnName("TitleAR");
            entity.Property(e => e.TitleEn)
                .HasMaxLength(50)
                .HasColumnName("TitleEN");

            entity.HasOne(d => d.AssetRegistrationProcess).WithMany(p => p.TempProcessCustomFieldData)
                .HasForeignKey(d => d.AssetRegistrationProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessCustomFieldData_TempProcessRegistrationItem");

            entity.HasOne(d => d.Field).WithMany(p => p.TempProcessCustomFieldData)
                .HasForeignKey(d => d.FieldId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessCustomFieldData_CustomFieldsDefinition");
        });

        modelBuilder.Entity<TempProcessEditItem>(entity =>
        {
            entity.HasKey(e => e.ProcessId);

            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.TempProcessId).HasColumnName("TempProcessID");

            entity.HasOne(d => d.Asset).WithMany(p => p.TempProcessEditItems)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessEditItems_Assets");

            entity.HasOne(d => d.TempProcess).WithMany(p => p.TempProcessEditItems)
                .HasForeignKey(d => d.TempProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessEditItems_TempProcess");
        });

        modelBuilder.Entity<TempProcessGuardenItem>(entity =>
        {
            entity.HasKey(e => e.ProcessId);

            entity.ToTable("TempProcessGuardenItem");

            entity.Property(e => e.ProcessId)
                .ValueGeneratedNever()
                .HasColumnName("ProcessID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.NewAssetSateId).HasColumnName("NewAssetSateID");
            entity.Property(e => e.NewGuardenId).HasColumnName("NewGuardenID");
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.TempProcessId).HasColumnName("TempProcessID");

            entity.HasOne(d => d.Asset).WithMany(p => p.TempProcessGuardenItems)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessGuardenItem_Assets");

            entity.HasOne(d => d.NewAssetSate).WithMany(p => p.TempProcessGuardenItems)
                .HasForeignKey(d => d.NewAssetSateId)
                .HasConstraintName("FK_TempProcessGuardenItem_LTAssetState");

            entity.HasOne(d => d.NewGuarden).WithMany(p => p.TempProcessGuardenItems)
                .HasForeignKey(d => d.NewGuardenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessGuardenItem_Employee");

            entity.HasOne(d => d.TempProcess).WithMany(p => p.TempProcessGuardenItems)
                .HasForeignKey(d => d.TempProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessGuardenItem_TempProcess");
        });

        modelBuilder.Entity<TempProcessLog>(entity =>
        {
            entity.HasKey(e => e.ProcessLogId).HasName("PK_TempAssetProcessLog");

            entity.ToTable("TempProcessLog");

            entity.Property(e => e.ProcessLogId).HasColumnName("ProcessLogID");
            entity.Property(e => e.ForUserId).HasColumnName("ForUserID");
            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            entity.Property(e => e.ProcessLogDate).HasColumnType("datetime");
            entity.Property(e => e.ProcessUserActionId).HasColumnName("ProcessUserActionID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.ForUser).WithMany(p => p.TempProcessLogForUsers)
                .HasForeignKey(d => d.ForUserId)
                .HasConstraintName("FK_TempProcessLog_UserAccount");

            entity.HasOne(d => d.Process).WithMany(p => p.TempProcessLogs)
                .HasForeignKey(d => d.ProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempAssetProcessLog_TempAssetProcess");

            entity.HasOne(d => d.ProcessStatusNavigation).WithMany(p => p.TempProcessLogs)
                .HasForeignKey(d => d.ProcessStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessLog_LTProcessState");

            entity.HasOne(d => d.ProcessTypeNavigation).WithMany(p => p.TempProcessLogs)
                .HasForeignKey(d => d.ProcessType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessLog_LTProcessType");

            entity.HasOne(d => d.ProcessUserAction).WithMany(p => p.TempProcessLogs)
                .HasForeignKey(d => d.ProcessUserActionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessLog_LTProcessUserAction");

            entity.HasOne(d => d.User).WithMany(p => p.TempProcessLogUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempAssetProcessLog_UserAccount");
        });

        modelBuilder.Entity<TempProcessMaintenanceItem>(entity =>
        {
            entity.HasKey(e => e.ProcessId).HasName("PK_TempAssetMaintenanceProcess");

            entity.ToTable("TempProcessMaintenanceItem");

            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.MaintenanceLocationId).HasColumnName("MaintenanceLocationID");
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.TempAssetProcessId).HasColumnName("TempAssetProcessID");

            entity.HasOne(d => d.Employee).WithMany(p => p.TempProcessMaintenanceItems)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempAssetMaintenanceProcess_Employee");

            entity.HasOne(d => d.TempAssetProcess).WithMany(p => p.TempProcessMaintenanceItems)
                .HasForeignKey(d => d.TempAssetProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempAssetMaintenanceProcess_TempAssetProcess");
        });

        modelBuilder.Entity<TempProcessRegeofencingItem>(entity =>
        {
            entity.HasKey(e => e.ProcessId).HasName("PK_TemporaryAssetRegeofencing");

            entity.ToTable("TempProcessRegeofencingItem");

            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.NewLocationId).HasColumnName("NewLocationID");
            entity.Property(e => e.TempAssetProcessId).HasColumnName("TempAssetProcessID");
            entity.Property(e => e.TransferDate).HasColumnType("datetime");

            entity.HasOne(d => d.Asset).WithMany(p => p.TempProcessRegeofencingItems)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemporaryAssetRegeofencing_Assets");

            entity.HasOne(d => d.NewLocation).WithMany(p => p.TempProcessRegeofencingItems)
                .HasForeignKey(d => d.NewLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemporaryAssetRegeofencing_Locations");

            entity.HasOne(d => d.TempAssetProcess).WithMany(p => p.TempProcessRegeofencingItems)
                .HasForeignKey(d => d.TempAssetProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemporaryAssetRegeofencing_TempAssetProcess");
        });

        modelBuilder.Entity<TempProcessRegistrationItem>(entity =>
        {
            entity.HasKey(e => e.ProcessId).HasName("PK_TempAssetRegistrationProcess");

            entity.ToTable("TempProcessRegistrationItem");

            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            entity.Property(e => e.AddDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");
            entity.Property(e => e.AssetPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AssetStateId).HasColumnName("AssetStateID");
            entity.Property(e => e.ColorId).HasColumnName("ColorID");
            entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExtraUnitCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDepreciable).HasDefaultValue(true);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MaintancePlanId).HasColumnName("MaintancePlanID");
            entity.Property(e => e.ManufactureSn).HasColumnName("ManufactureSN");
            entity.Property(e => e.ProfitUnitAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RealtedAssetTransactionId).HasColumnName("RealtedAssetTransactionID");
            entity.Property(e => e.RefrenceNo).HasMaxLength(50);
            entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TempProcessId).HasColumnName("TempProcessID");
            entity.Property(e => e.WeightUnitId)
                .HasDefaultValue(2)
                .HasColumnName("WeightUnitID");

            entity.HasOne(d => d.AssetClass).WithMany(p => p.TempProcessRegistrationItems)
                .HasForeignKey(d => d.AssetClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemporaryAssets_AssetsClassfications");

            entity.HasOne(d => d.AssetState).WithMany(p => p.TempProcessRegistrationItems)
                .HasForeignKey(d => d.AssetStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempAssetRegistrationProcess_LTAssetState");

            entity.HasOne(d => d.Color).WithMany(p => p.TempProcessRegistrationItems)
                .HasForeignKey(d => d.ColorId)
                .HasConstraintName("FK_TempProcessRegistrationItem_LTColor");

            entity.HasOne(d => d.Location).WithMany(p => p.TempProcessRegistrationItems)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemporaryAssets_Locations");

            entity.HasOne(d => d.MaintancePlan).WithMany(p => p.TempProcessRegistrationItems)
                .HasForeignKey(d => d.MaintancePlanId)
                .HasConstraintName("FK_TempProcessRegistrationItem_AssetMaintenancePlan");

            entity.HasOne(d => d.RealtedAssetTransaction).WithMany(p => p.TempProcessRegistrationItems)
                .HasForeignKey(d => d.RealtedAssetTransactionId)
                .HasConstraintName("FK_TempProcessRegistrationItem_AssetTransactionLog");

            entity.HasOne(d => d.TempProcess).WithMany(p => p.TempProcessRegistrationItems)
                .HasForeignKey(d => d.TempProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempAssetRegistrationProcess_TempAssetProcess");

            entity.HasOne(d => d.UnitNavigation).WithMany(p => p.TempProcessRegistrationItemUnitNavigations)
                .HasForeignKey(d => d.Unit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessRegistrationItem_LTAssetUnit");

            entity.HasOne(d => d.WeightUnit).WithMany(p => p.TempProcessRegistrationItemWeightUnits)
                .HasForeignKey(d => d.WeightUnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessRegistrationItem_LTAssetUnit_Weight");
        });

        modelBuilder.Entity<TempProcessRegistrationItemLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK_TempProcessRegistrationItemLog");

            entity.ToTable("TempProcessRegistrationItem_Log");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.AddDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");
            entity.Property(e => e.AssetPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AssetStateId).HasColumnName("AssetStateID");
            entity.Property(e => e.ColorId).HasColumnName("ColorID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ManufactureSn).HasColumnName("ManufactureSN");
            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            entity.Property(e => e.RealtedAssetTransactionId).HasColumnName("RealtedAssetTransactionID");
            entity.Property(e => e.RefrenceNo).HasMaxLength(50);
            entity.Property(e => e.TempAssetProcessId).HasColumnName("TempAssetProcessID");

            entity.HasOne(d => d.AssetClass).WithMany(p => p.TempProcessRegistrationItemLogs)
                .HasForeignKey(d => d.AssetClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessRegistrationItem_Log_AssetsClassfication");

            entity.HasOne(d => d.AssetState).WithMany(p => p.TempProcessRegistrationItemLogs)
                .HasForeignKey(d => d.AssetStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessRegistrationItem_Log_LTAssetState");

            entity.HasOne(d => d.Color).WithMany(p => p.TempProcessRegistrationItemLogs)
                .HasForeignKey(d => d.ColorId)
                .HasConstraintName("FK_TempProcessRegistrationItem_Log_LTColor");

            entity.HasOne(d => d.Location).WithMany(p => p.TempProcessRegistrationItemLogs)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessRegistrationItem_Log_Location");

            entity.HasOne(d => d.RealtedAssetTransaction).WithMany(p => p.TempProcessRegistrationItemLogs)
                .HasForeignKey(d => d.RealtedAssetTransactionId)
                .HasConstraintName("FK_TempProcessRegistrationItem_Log_AssetTransactionLog");

            entity.HasOne(d => d.TempAssetProcess).WithMany(p => p.TempProcessRegistrationItemLogs)
                .HasForeignKey(d => d.TempAssetProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessRegistrationItem_Log_TempProcess");

            entity.HasOne(d => d.UnitNavigation).WithMany(p => p.TempProcessRegistrationItemLogs)
                .HasForeignKey(d => d.Unit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessRegistrationItem_Log_LTAssetUnit");
        });

        modelBuilder.Entity<TempProcessReturnItem>(entity =>
        {
            entity.HasKey(e => e.ProcessId);

            entity.ToTable("TempProcessReturnItem");

            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            entity.Property(e => e.NewAssetStateId).HasColumnName("NewAssetStateID");
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.TempProcessId).HasColumnName("TempProcessID");
            entity.Property(e => e.WarehouseLocationId).HasColumnName("WarehouseLocationID");

            entity.HasOne(d => d.NewAssetState).WithMany(p => p.TempProcessReturnItems)
                .HasForeignKey(d => d.NewAssetStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessReturnItem_LTAssetState");

            entity.HasOne(d => d.TempProcess).WithMany(p => p.TempProcessReturnItems)
                .HasForeignKey(d => d.TempProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessReturnItem_TempProcess");

            entity.HasOne(d => d.WarehouseLocation).WithMany(p => p.TempProcessReturnItems)
                .HasForeignKey(d => d.WarehouseLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessReturnItem_Location");
        });

        modelBuilder.Entity<TempProcessTransferItem>(entity =>
        {
            entity.HasKey(e => e.ProcessId).HasName("PK_TempAssetTransferProcess");

            entity.ToTable("TempProcessTransferItem");

            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.NewAssetTransferStateId).HasColumnName("NewAssetTransferStateID");
            entity.Property(e => e.NewGuardianshipId).HasColumnName("NewGuardianshipID");
            entity.Property(e => e.NewLocationId).HasColumnName("NewLocationID");
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.TempProcessId).HasColumnName("TempProcessID");

            entity.HasOne(d => d.Asset).WithMany(p => p.TempProcessTransferItems)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessTransferItem_Assets");

            entity.HasOne(d => d.NewAssetTransferState).WithMany(p => p.TempProcessTransferItems)
                .HasForeignKey(d => d.NewAssetTransferStateId)
                .HasConstraintName("FK_TempProcessTransferItem_LTAssetState");

            entity.HasOne(d => d.NewGuardianship).WithMany(p => p.TempProcessTransferItems)
                .HasForeignKey(d => d.NewGuardianshipId)
                .HasConstraintName("FK_TempProcessTransferItem_Employee");

            entity.HasOne(d => d.NewLocation).WithMany(p => p.TempProcessTransferItems)
                .HasForeignKey(d => d.NewLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempProcessTransferItem_Location");

            entity.HasOne(d => d.TempProcess).WithMany(p => p.TempProcessTransferItems)
                .HasForeignKey(d => d.TempProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TempAssetTransferProcess_TempAssetProcess");
        });

        modelBuilder.Entity<TicketVideoRecoding>(entity =>
        {
            entity.HasKey(e => e.TicketVideoRecordingId).HasName("PK_TicketVideoRecodings");

            entity.ToTable("TicketVideoRecoding");

            entity.Property(e => e.TicketVideoRecordingId).HasColumnName("TicketVideoRecordingID");
            entity.Property(e => e.RecordCameraId).HasColumnName("RecordCameraID");
            entity.Property(e => e.TicketId).HasColumnName("TicketID");
        });

        modelBuilder.Entity<UnusedDataBackupConfig>(entity =>
        {
            entity.HasKey(e => e.BackupJobId);

            entity.ToTable("UnusedDataBackupConfig");

            entity.Property(e => e.BackupJobId).HasColumnName("BackupJobID");
            entity.Property(e => e.BackupTypeId).HasColumnName("BackupTypeID");
            entity.Property(e => e.Dbsize).HasColumnName("DBSize");
            entity.Property(e => e.JobName).HasMaxLength(150);
            entity.Property(e => e.NextScheduledRun).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserAccessLocation>(entity =>
        {
            entity.HasKey(e => e.UserAccesLocationId).HasName("PK_UserLocations");

            entity.ToTable("UserAccessLocation");

            entity.HasIndex(e => new { e.LocationId, e.UserId }, "_dta_index_UserAccessLocation_7_1310627712__K3_K2");

            entity.Property(e => e.UserAccesLocationId).HasColumnName("UserAccesLocationID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Location).WithMany(p => p.UserAccessLocations)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserLocations_Locations");

            entity.HasOne(d => d.Transaction).WithMany(p => p.UserAccessLocations)
                .HasForeignKey(d => d.TransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserAccessLocation_SystemTransaction");

            entity.HasOne(d => d.User).WithMany(p => p.UserAccessLocations)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserAccessLocation_UserAccount");
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_Userss");

            entity.ToTable("UserAccount");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.DefaultLanguageId).HasColumnName("DefaultLanguageID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.IsAdaccount).HasColumnName("IsADAccount");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.MustChangePasswordNextLogin).HasDefaultValue(false);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumberConfirmed).HasDefaultValue(false);
            entity.Property(e => e.TwoFactorEnabled).HasDefaultValue(true);
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.UserAccountAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .HasConstraintName("FK_UserAccount_SystemTransaction");

            entity.HasOne(d => d.DefaultLanguage).WithMany(p => p.UserAccounts)
                .HasForeignKey(d => d.DefaultLanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_LTLanguages");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.UserAccountUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_UserAccount_SystemTransaction1");
        });

        modelBuilder.Entity<UserAlarm>(entity =>
        {
            entity.HasKey(e => e.UserAlarmId).HasName("PK_TicketTypeUserAlarmTypes");

            entity.ToTable("UserAlarm");

            entity.Property(e => e.UserAlarmId).HasColumnName("UserAlarmID");
            entity.Property(e => e.AlarmNotificationTypeId).HasColumnName("AlarmNotificationTypeID");
            entity.Property(e => e.AlarmTypeId).HasColumnName("AlarmTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.AlarmNotificationType).WithMany(p => p.UserAlarms)
                .HasForeignKey(d => d.AlarmNotificationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketTypeUserAlarmTypes_LTTicketAlarmTypes");

            entity.HasOne(d => d.AlarmType).WithMany(p => p.UserAlarms)
                .HasForeignKey(d => d.AlarmTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketTypeUserAlarmTypes_LTTicketTypes");

            entity.HasOne(d => d.User).WithMany(p => p.UserAlarms)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketTypeUserAlarmTypes_Users");
        });

        modelBuilder.Entity<UserAssetReport>(entity =>
        {
            entity.ToTable("UserAssetReport");

            entity.Property(e => e.UserAssetReportId).HasColumnName("UserAssetReportID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Form).WithMany(p => p.UserAssetReports)
                .HasForeignKey(d => d.FormId)
                .HasConstraintName("FK_UserAssetReport_AssetForm");

            entity.HasOne(d => d.User).WithMany(p => p.UserAssetReports)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserAssetReport_UserAccount");
        });

        modelBuilder.Entity<UserGroup>(entity =>
        {
            entity.HasKey(e => e.UserGroupId).HasName("PK_Groups");

            entity.ToTable("UserGroup");

            entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.GroupDescription).HasColumnType("text");
            entity.Property(e => e.GroupName).HasMaxLength(50);
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.UserGroupAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserGroup_SystemTransaction");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.UserGroupUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_UserGroup_SystemTransactionUpdate");
        });

        modelBuilder.Entity<UserLoginLog>(entity =>
        {
            entity.ToTable("UserLoginLog");

            entity.Property(e => e.UserLoginLogId).HasColumnName("UserLoginLogID");
            entity.Property(e => e.BrowserName).HasMaxLength(50);
            entity.Property(e => e.LoginDate).HasColumnType("datetime");
            entity.Property(e => e.LogoutDate).HasColumnType("datetime");
            entity.Property(e => e.MachineIp)
                .HasMaxLength(50)
                .HasColumnName("MachineIP");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserLoginLogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserLoginLog_UserAccount");
        });

        modelBuilder.Entity<UserProcessType>(entity =>
        {
            entity.ToTable("UserProcessType");

            entity.HasIndex(e => new { e.UserId, e.ProcessTypeId }, "IX_UserProcessType").IsUnique();

            entity.Property(e => e.UserProcessTypeId).HasColumnName("UserProcessTypeID");
            entity.Property(e => e.ProcessTypeId).HasColumnName("ProcessTypeID");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.ProcessType).WithMany(p => p.UserProcessTypes)
                .HasForeignKey(d => d.ProcessTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserProcessType_LTProcessType");

            entity.HasOne(d => d.Transaction).WithMany(p => p.UserProcessTypes)
                .HasForeignKey(d => d.TransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserProcessType_SystemTransaction");

            entity.HasOne(d => d.User).WithMany(p => p.UserProcessTypes)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserProcessType_UserAccount");
        });

        modelBuilder.Entity<UserProfileFavClass>(entity =>
        {
            entity.ToTable("UserProfileFavClass");

            entity.Property(e => e.UserProfileFavClassId).HasColumnName("UserProfileFavClassID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Class).WithMany(p => p.UserProfileFavClasses)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserProfileFavClass_AssetsClassfication");

            entity.HasOne(d => d.User).WithMany(p => p.UserProfileFavClasses)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserProfileFavClass_UserAccount");
        });

        modelBuilder.Entity<UserProfileFavLocation>(entity =>
        {
            entity.ToTable("UserProfileFavLocation");

            entity.Property(e => e.UserProfileFavLocationId).HasColumnName("UserProfileFavLocationID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Location).WithMany(p => p.UserProfileFavLocations)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserProfileFavLocation_Location");

            entity.HasOne(d => d.User).WithMany(p => p.UserProfileFavLocations)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserProfileFavLocation_UserAccount");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.UserRoleId).HasName("PK_UserGroup");

            entity.ToTable("UserRole");

            entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRole_SystemTransaction");

            entity.HasOne(d => d.Group).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRole_UserGroup");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRole_User");
        });

        modelBuilder.Entity<UserScheduleI>(entity =>
        {
            entity.HasKey(e => e.UserScheduleId);

            entity.ToTable("UserScheduleI");

            entity.Property(e => e.UserScheduleId).HasColumnName("UserScheduleID");
            entity.Property(e => e.AssetFormId).HasColumnName("AssetFormID");
            entity.Property(e => e.DayId).HasColumnName("DayID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.AssetForm).WithMany(p => p.UserScheduleIs)
                .HasForeignKey(d => d.AssetFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserScheduleI_AssetForm");

            entity.HasOne(d => d.Day).WithMany(p => p.UserScheduleIs)
                .HasForeignKey(d => d.DayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserScheduleI_LTDayName");

            entity.HasOne(d => d.User).WithMany(p => p.UserScheduleIs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserScheduleI_UserAccount");
        });

        modelBuilder.Entity<UserScheduleIlog>(entity =>
        {
            entity.HasKey(e => e.UserScheduleId);

            entity.ToTable("UserScheduleILog");

            entity.Property(e => e.UserScheduleId)
                .ValueGeneratedNever()
                .HasColumnName("UserScheduleID");
            entity.Property(e => e.DayId).HasColumnName("DayID");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.ToDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Day).WithMany(p => p.UserScheduleIlogs)
                .HasForeignKey(d => d.DayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserScheduleILog_LTDayName");

            entity.HasOne(d => d.User).WithMany(p => p.UserScheduleIlogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserScheduleILog_UserAccount");
        });

        modelBuilder.Entity<UserTask>(entity =>
        {
            entity.ToTable("UserTask");

            entity.Property(e => e.UserTaskId)
                .ValueGeneratedNever()
                .HasColumnName("UserTaskID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TaskRoleId).HasColumnName("TaskRoleID");
            entity.Property(e => e.UserTaskTypeId).HasColumnName("UserTaskTypeID");

            entity.HasOne(d => d.TaskRole).WithMany(p => p.UserTasks)
                .HasForeignKey(d => d.TaskRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserTask_TaskRole");
        });

        modelBuilder.Entity<UserTaskAction>(entity =>
        {
            entity.ToTable("UserTaskAction");

            entity.Property(e => e.UserTaskActionId)
                .ValueGeneratedNever()
                .HasColumnName("UserTaskActionID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserTaskId).HasColumnName("UserTaskID");

            entity.HasOne(d => d.User).WithMany(p => p.UserTaskActions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserTaskAction_UserAccount");

            entity.HasOne(d => d.UserTask).WithMany(p => p.UserTaskActions)
                .HasForeignKey(d => d.UserTaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserTaskAction_UserTask");
        });

        modelBuilder.Entity<UserTaskActionLog>(entity =>
        {
            entity.ToTable("UserTaskActionLog");

            entity.Property(e => e.UserTaskActionLogId)
                .ValueGeneratedNever()
                .HasColumnName("UserTaskActionLogID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.UserTaskActionId).HasColumnName("UserTaskActionID");
            entity.Property(e => e.UserTaskId).HasColumnName("UserTaskID");

            entity.HasOne(d => d.UserTaskAction).WithMany(p => p.UserTaskActionLogs)
                .HasForeignKey(d => d.UserTaskActionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserTaskActionLog_UserTaskAction");

            entity.HasOne(d => d.UserTask).WithMany(p => p.UserTaskActionLogs)
                .HasForeignKey(d => d.UserTaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserTaskActionLog_UserTask");
        });

        modelBuilder.Entity<UserTaskRole>(entity =>
        {
            entity.ToTable("UserTaskRole");

            entity.Property(e => e.UserTaskRoleId)
                .ValueGeneratedNever()
                .HasColumnName("UserTaskRoleID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.TaskRoleId).HasColumnName("TaskRoleID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.TaskRole).WithMany(p => p.UserTaskRoles)
                .HasForeignKey(d => d.TaskRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserTaskRole_TaskRole");

            entity.HasOne(d => d.User).WithMany(p => p.UserTaskRoles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserTaskRole_UserAccount");
        });

        modelBuilder.Entity<VClass8>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vClass8");

            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetId2).HasColumnName("AssetID2");
            entity.Property(e => e.AssetTagId).HasColumnName("AssetTagID");
            entity.Property(e => e.ClassCode).HasMaxLength(50);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.TagId)
                .HasMaxLength(50)
                .HasColumnName("TagID");
            entity.Property(e => e.TagId2)
                .HasMaxLength(50)
                .HasColumnName("TagID2");
            entity.Property(e => e.TagTypeId).HasColumnName("TagTypeID");
            entity.Property(e => e.Tid).HasColumnName("TID");
        });

        modelBuilder.Entity<ViewAssetRule>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AssetRule");

            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.AllowedNewStateId).HasColumnName("AllowedNewStateID");
            entity.Property(e => e.CuurentStateId).HasColumnName("CuurentStateID");
        });

        modelBuilder.Entity<ViewJeddah>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Jeddah");

            entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
        });

        modelBuilder.Entity<ViewRiyadh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Riyadh");

            entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
        });

        modelBuilder.Entity<WarehousReturnFormItem>(entity =>
        {
            entity.HasKey(e => e.WarehouseFormItemId);

            entity.ToTable("WarehousReturnFormItem");

            entity.Property(e => e.WarehouseFormItemId).HasColumnName("WarehouseFormItemID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTransactionId).HasColumnName("AssetTransactionID");
            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.OldAssetStateId).HasColumnName("OldAssetStateID");
            entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            entity.Property(e => e.ReturnedFromLocationId).HasColumnName("ReturnedFromLocationID");

            entity.HasOne(d => d.Asset).WithMany(p => p.WarehousReturnFormItems)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetReturnFormDetails_Assets");

            entity.HasOne(d => d.AssetTransaction).WithMany(p => p.WarehousReturnFormItems)
                .HasForeignKey(d => d.AssetTransactionId)
                .HasConstraintName("FK_WarehousReturnFormItem_AssetTransactionLog");

            entity.HasOne(d => d.Form).WithMany(p => p.WarehousReturnFormItems)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehousReturnFormItem_WarehouseForm");

            entity.HasOne(d => d.OldAssetState).WithMany(p => p.WarehousReturnFormItems)
                .HasForeignKey(d => d.OldAssetStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehousReturnFormItem_LTAssetState");

            entity.HasOne(d => d.Process).WithMany(p => p.WarehousReturnFormItems)
                .HasForeignKey(d => d.ProcessId)
                .HasConstraintName("FK_WarehousReturnFormItem_TempProcessReturnItem");

            entity.HasOne(d => d.ReturnedFromLocation).WithMany(p => p.WarehousReturnFormItems)
                .HasForeignKey(d => d.ReturnedFromLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehousReturnFormItem_Location");
        });

        modelBuilder.Entity<WarehouseExportForm>(entity =>
        {
            entity.HasKey(e => e.WarehouseFormId).HasName("PK_AssetReceiveForm");

            entity.ToTable("WarehouseExportForm");

            entity.Property(e => e.WarehouseFormId)
                .ValueGeneratedNever()
                .HasColumnName("WarehouseFormID");
            entity.Property(e => e.RecipiantEmployeeId).HasColumnName("RecipiantEmployeeID");
            entity.Property(e => e.RequestLocationId).HasColumnName("RequestLocationID");
            entity.Property(e => e.RequestManagerId).HasColumnName("RequestManagerID");

            entity.HasOne(d => d.RecipiantEmployee).WithMany(p => p.WarehouseExportFormRecipiantEmployees)
                .HasForeignKey(d => d.RecipiantEmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetReceiveForm_Employee_RecipiantEmployee");

            entity.HasOne(d => d.RequestLocation).WithMany(p => p.WarehouseExportForms)
                .HasForeignKey(d => d.RequestLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetReceiveForm_Location");

            entity.HasOne(d => d.RequestManager).WithMany(p => p.WarehouseExportFormRequestManagers)
                .HasForeignKey(d => d.RequestManagerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetReceiveForm_Employee_RequestManager");

            entity.HasOne(d => d.WarehouseForm).WithOne(p => p.WarehouseExportForm)
                .HasForeignKey<WarehouseExportForm>(d => d.WarehouseFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetReceiveForm_AssetForm");
        });

        modelBuilder.Entity<WarehouseExportFormItem>(entity =>
        {
            entity.HasKey(e => e.ReciveFormItemId).HasName("PK_AssetReceiveFormDetails");

            entity.ToTable("WarehouseExportFormItem");

            entity.Property(e => e.ReciveFormItemId).HasColumnName("ReciveFormItemID");
            entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");
            entity.Property(e => e.WarehouseFormId).HasColumnName("WarehouseFormID");

            entity.HasOne(d => d.AssetClass).WithMany(p => p.WarehouseExportFormItems)
                .HasForeignKey(d => d.AssetClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehouseReceiveFormItem_AssetsClassfication");

            entity.HasOne(d => d.UnitNavigation).WithMany(p => p.WarehouseExportFormItems)
                .HasForeignKey(d => d.Unit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehouseReceiveFormItem_LTAssetUnit");

            entity.HasOne(d => d.WarehouseForm).WithMany(p => p.WarehouseExportFormItems)
                .HasForeignKey(d => d.WarehouseFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehouseReceiveFormItem_WarehouseForm");
        });

        modelBuilder.Entity<WarehouseForm>(entity =>
        {
            entity.HasKey(e => e.FormId).HasName("PK_AssetRegisterationForms");

            entity.ToTable("WarehouseForm");

            entity.Property(e => e.FormId)
                .ValueGeneratedNever()
                .HasColumnName("FormID");
            entity.Property(e => e.WarehouseLocationId).HasColumnName("WarehouseLocationID");
            entity.Property(e => e.WarehouseManagerId).HasColumnName("WarehouseManagerID");
            entity.Property(e => e.WarehousesSheriffId).HasColumnName("WarehousesSheriffID");

            entity.HasOne(d => d.Form).WithOne(p => p.WarehouseForm)
                .HasForeignKey<WarehouseForm>(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehouseForm_AssetForm");

            entity.HasOne(d => d.WarehouseLocation).WithMany(p => p.WarehouseForms)
                .HasForeignKey(d => d.WarehouseLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetWarehouseForm_Location");

            entity.HasOne(d => d.WarehouseManager).WithMany(p => p.WarehouseFormWarehouseManagers)
                .HasForeignKey(d => d.WarehouseManagerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetWarehouseForm_Employee_WarehouseManager");

            entity.HasOne(d => d.WarehousesSheriff).WithMany(p => p.WarehouseFormWarehousesSheriffs)
                .HasForeignKey(d => d.WarehousesSheriffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetWarehouseForm_Employee_WarehousesSheriff");
        });

        modelBuilder.Entity<WarehouseImportForm>(entity =>
        {
            entity.HasKey(e => e.WarehouseFormId).HasName("PK_AssetSupplyForm");

            entity.ToTable("WarehouseImportForm");

            entity.Property(e => e.WarehouseFormId)
                .ValueGeneratedNever()
                .HasColumnName("WarehouseFormID");
            entity.Property(e => e.RecipiantEmployeeId).HasColumnName("RecipiantEmployeeID");

            entity.HasOne(d => d.RecipiantEmployee).WithMany(p => p.WarehouseImportForms)
                .HasForeignKey(d => d.RecipiantEmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetSupplyForm_Employee");

            entity.HasOne(d => d.WarehouseForm).WithOne(p => p.WarehouseImportForm)
                .HasForeignKey<WarehouseImportForm>(d => d.WarehouseFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetSupplyForm_AssetForm");
        });

        modelBuilder.Entity<WarehouseImportFormItem>(entity =>
        {
            entity.HasKey(e => e.SupplyFormItemId).HasName("PK_AssetRegistrationFormDetails");

            entity.ToTable("WarehouseImportFormItem");

            entity.Property(e => e.SupplyFormItemId).HasColumnName("SupplyFormItemID");
            entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");
            entity.Property(e => e.Price)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.WarehouseFormId).HasColumnName("WarehouseFormID");

            entity.HasOne(d => d.AssetClass).WithMany(p => p.WarehouseImportFormItems)
                .HasForeignKey(d => d.AssetClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetRegistrationFormDetails_AssetsClassfication");

            entity.HasOne(d => d.UnitNavigation).WithMany(p => p.WarehouseImportFormItems)
                .HasForeignKey(d => d.Unit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehouseSupplyFormItem_LTAssetUnit");

            entity.HasOne(d => d.WarehouseForm).WithMany(p => p.WarehouseImportFormItems)
                .HasForeignKey(d => d.WarehouseFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehouseFormItem_AssetWarehouseForm");
        });

        modelBuilder.Entity<WarehouseManager>(entity =>
        {
            entity.HasKey(e => e.WarehouseLocationId);

            entity.ToTable("WarehouseManager");

            entity.Property(e => e.WarehouseLocationId)
                .ValueGeneratedNever()
                .HasColumnName("WarehouseLocationID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");
            entity.Property(e => e.WarehouseManagerId).HasColumnName("WarehouseManagerID");
            entity.Property(e => e.WarehousesSheriffId).HasColumnName("WarehousesSheriffID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.WarehouseManagerAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehouseManager_SystemTransaction_Add");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.WarehouseManagerUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_WarehouseManager_SystemTransaction_Update");

            entity.HasOne(d => d.WarehouseLocation).WithOne(p => p.WarehouseManager)
                .HasForeignKey<WarehouseManager>(d => d.WarehouseLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehouseManager_Location");

            entity.HasOne(d => d.WarehouseManagerNavigation).WithMany(p => p.WarehouseManagerWarehouseManagerNavigations)
                .HasForeignKey(d => d.WarehouseManagerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehouseManager_EmployeeManager");

            entity.HasOne(d => d.WarehousesSheriff).WithMany(p => p.WarehouseManagerWarehousesSheriffs)
                .HasForeignKey(d => d.WarehousesSheriffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehouseManager_EmployeeSheriff");
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.ToTable("Zone");

            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
            entity.Property(e => e.AddTransactionId).HasColumnName("AddTransactionID");
            entity.Property(e => e.UpdateTransactionId).HasColumnName("UpdateTransactionID");

            entity.HasOne(d => d.AddTransaction).WithMany(p => p.ZoneAddTransactions)
                .HasForeignKey(d => d.AddTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Zone_AddSystemTransaction");

            entity.HasOne(d => d.UpdateTransaction).WithMany(p => p.ZoneUpdateTransactions)
                .HasForeignKey(d => d.UpdateTransactionId)
                .HasConstraintName("FK_Zone_UpdateSystemTransaction");
        });

        modelBuilder.Entity<ZoneLocation>(entity =>
        {
            entity.ToTable("ZoneLocation");

            entity.Property(e => e.ZoneLocationId).HasColumnName("ZoneLocationID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

            entity.HasOne(d => d.Location).WithMany(p => p.ZoneLocations)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ZoneLocation_Location");

            entity.HasOne(d => d.Zone).WithMany(p => p.ZoneLocations)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ZoneLocation_ZoneLocation");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    private void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // your entity configurations...

        //OnModelCreatingPartial(modelBuilder);  // <- this must be called
    }
}
