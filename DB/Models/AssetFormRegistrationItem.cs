using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormRegistrationItem
{
    public int AssetRegistrationFormItemId { get; set; }

    public int AssetRegistrationFormId { get; set; }

    public int? AssetId { get; set; }

    public int? AssetTransactionId { get; set; }

    public int? ProcessId { get; set; }

    public virtual Asset? Asset { get; set; }

    public virtual AssetForm AssetRegistrationForm { get; set; } = null!;

    public virtual AssetTransactionLog? AssetTransaction { get; set; }

    public virtual TempProcessRegistrationItem? Process { get; set; }
}
