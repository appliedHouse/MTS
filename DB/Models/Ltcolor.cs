using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Ltcolor
{
    public int ColorId { get; set; }

    public string ColorKey { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<AssetFormEditAssetItem> AssetFormEditAssetItems { get; set; } = new List<AssetFormEditAssetItem>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogs { get; set; } = new List<AssetTransactionLog>();

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();

    public virtual ICollection<TempProcessRegistrationItemLog> TempProcessRegistrationItemLogs { get; set; } = new List<TempProcessRegistrationItemLog>();

    public virtual ICollection<TempProcessRegistrationItem> TempProcessRegistrationItems { get; set; } = new List<TempProcessRegistrationItem>();
}
