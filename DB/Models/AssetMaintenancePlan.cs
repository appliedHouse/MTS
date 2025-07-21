using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetMaintenancePlan
{
    public int MaintenancePlanId { get; set; }

    public string MaintenancePlanName { get; set; } = null!;

    public int MaintenancePlanPeriodPerDay { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual ICollection<AssetFormEditAssetItem> AssetFormEditAssetItems { get; set; } = new List<AssetFormEditAssetItem>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogs { get; set; } = new List<AssetTransactionLog>();

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();

    public virtual ICollection<AssetsClassProfile> AssetsClassProfiles { get; set; } = new List<AssetsClassProfile>();

    public virtual ICollection<TempProcessRegistrationItem> TempProcessRegistrationItems { get; set; } = new List<TempProcessRegistrationItem>();

    public virtual SystemTransaction? UpdateTransaction { get; set; }
}
