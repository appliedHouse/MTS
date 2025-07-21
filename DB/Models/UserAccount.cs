using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class UserAccount
{
    public int UserId { get; set; }

    public string Id { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool EmailConfirmed { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public bool? PhoneNumberConfirmed { get; set; }

    public bool IsActive { get; set; }

    public bool? MustChangePasswordNextLogin { get; set; }

    public int DefaultLanguageId { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public bool IsAdaccount { get; set; }

    public string? AlterantEmail { get; set; }

    public int AccessFailedCount { get; set; }

    public bool LockoutEnabled { get; set; }

    public DateTime? LockoutEndDateUtc { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public Guid? AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? NormalizedEmail { get; set; }

    public virtual SystemTransaction? AddTransaction { get; set; }

    public virtual ICollection<Alarm> AlarmClosedByUserNavigations { get; set; } = new List<Alarm>();

    public virtual ICollection<Alarm> AlarmOwnerUsers { get; set; } = new List<Alarm>();

    public virtual ICollection<AssetFormAuditSession> AssetFormAuditSessions { get; set; } = new List<AssetFormAuditSession>();

    public virtual ICollection<AssetFormLog> AssetFormLogs { get; set; } = new List<AssetFormLog>();

    public virtual ICollection<AssetFormSaleReturn> AssetFormSaleReturns { get; set; } = new List<AssetFormSaleReturn>();

    public virtual ICollection<AssetFormSale> AssetFormSales { get; set; } = new List<AssetFormSale>();

    public virtual ICollection<AssetFormUserScheule> AssetFormUserScheules { get; set; } = new List<AssetFormUserScheule>();

    public virtual ICollection<AssetForm> AssetForms { get; set; } = new List<AssetForm>();

    public virtual ICollection<AssetReuseForm> AssetReuseForms { get; set; } = new List<AssetReuseForm>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogs { get; set; } = new List<AssetTransactionLog>();

    public virtual ICollection<AuditSessionPresentAsset> AuditSessionPresentAssets { get; set; } = new List<AuditSessionPresentAsset>();

    public virtual Ltlanguage DefaultLanguage { get; set; } = null!;

    public virtual ICollection<LiteUserService> LiteUserServices { get; set; } = new List<LiteUserService>();

    public virtual ICollection<MissingAsset> MissingAssetAddUsers { get; set; } = new List<MissingAsset>();

    public virtual ICollection<MissingAsset> MissingAssetModfiyUsers { get; set; } = new List<MissingAsset>();

    public virtual ICollection<ProcessedAssetFormLog> ProcessedAssetFormLogs { get; set; } = new List<ProcessedAssetFormLog>();

    public virtual ICollection<ProcessedAssetForm> ProcessedAssetForms { get; set; } = new List<ProcessedAssetForm>();

    public virtual ICollection<SystemBugsLog> SystemBugsLogs { get; set; } = new List<SystemBugsLog>();

    public virtual ICollection<SystemTransaction> SystemTransactions { get; set; } = new List<SystemTransaction>();

    public virtual ICollection<TempProcess> TempProcessAddedByNavigations { get; set; } = new List<TempProcess>();

    public virtual ICollection<TempProcessLog> TempProcessLogForUsers { get; set; } = new List<TempProcessLog>();

    public virtual ICollection<TempProcessLog> TempProcessLogUsers { get; set; } = new List<TempProcessLog>();

    public virtual ICollection<TempProcess> TempProcessTakenByNavigations { get; set; } = new List<TempProcess>();

    public virtual SystemTransaction? UpdateTransaction { get; set; }

    public virtual ICollection<UserAccessLocation> UserAccessLocations { get; set; } = new List<UserAccessLocation>();

    public virtual ICollection<UserAlarm> UserAlarms { get; set; } = new List<UserAlarm>();

    public virtual ICollection<UserAssetReport> UserAssetReports { get; set; } = new List<UserAssetReport>();

    public virtual ICollection<UserLoginLog> UserLoginLogs { get; set; } = new List<UserLoginLog>();

    public virtual ICollection<UserProcessType> UserProcessTypes { get; set; } = new List<UserProcessType>();

    public virtual ICollection<UserProfileFavClass> UserProfileFavClasses { get; set; } = new List<UserProfileFavClass>();

    public virtual ICollection<UserProfileFavLocation> UserProfileFavLocations { get; set; } = new List<UserProfileFavLocation>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    public virtual ICollection<UserScheduleIlog> UserScheduleIlogs { get; set; } = new List<UserScheduleIlog>();

    public virtual ICollection<UserScheduleI> UserScheduleIs { get; set; } = new List<UserScheduleI>();

    public virtual ICollection<UserTaskAction> UserTaskActions { get; set; } = new List<UserTaskAction>();

    public virtual ICollection<UserTaskRole> UserTaskRoles { get; set; } = new List<UserTaskRole>();
}
