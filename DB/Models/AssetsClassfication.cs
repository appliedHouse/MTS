using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetsClassfication
{
    public int ClassId { get; set; }

    public int? ParentClassId { get; set; }

    public string ClassName { get; set; } = null!;

    public string? ClassNameEn { get; set; }

    public string? ParentClassPath { get; set; }

    public string? ClassCode { get; set; }

    public string ClassImage { get; set; } = null!;

    public string? LevelNodeCode { get; set; }

    public int? ClassLevelId { get; set; }

    public bool IsActiveForHandheld { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public bool IsDeleted { get; set; }

    public int? RefId { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual ICollection<AssetFormEditAssetItem> AssetFormEditAssetItems { get; set; } = new List<AssetFormEditAssetItem>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogs { get; set; } = new List<AssetTransactionLog>();

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();

    public virtual AssetsClassProfile? AssetsClassProfile { get; set; }

    public virtual ICollection<AuditSessionClassResult> AuditSessionClassResults { get; set; } = new List<AuditSessionClassResult>();

    public virtual AssetsClassficationsLevel? ClassLevel { get; set; }

    public virtual ICollection<CustomFieldsDefinition> CustomFieldsDefinitions { get; set; } = new List<CustomFieldsDefinition>();

    public virtual ICollection<TempProcessRegistrationItemLog> TempProcessRegistrationItemLogs { get; set; } = new List<TempProcessRegistrationItemLog>();

    public virtual ICollection<TempProcessRegistrationItem> TempProcessRegistrationItems { get; set; } = new List<TempProcessRegistrationItem>();

    public virtual SystemTransaction? UpdateTransaction { get; set; }

    public virtual ICollection<UserProfileFavClass> UserProfileFavClasses { get; set; } = new List<UserProfileFavClass>();

    public virtual ICollection<WarehouseExportFormItem> WarehouseExportFormItems { get; set; } = new List<WarehouseExportFormItem>();

    public virtual ICollection<WarehouseImportFormItem> WarehouseImportFormItems { get; set; } = new List<WarehouseImportFormItem>();
}
