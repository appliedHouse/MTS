using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetReuseFormDetail
{
    public int AssetReuseFormId { get; set; }

    public int AssetId { get; set; }

    public int AssetStateOnReturn { get; set; }

    public int? GurdianshipFormIdbeforReuse { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual LtassetState AssetStateOnReturnNavigation { get; set; } = null!;
}
