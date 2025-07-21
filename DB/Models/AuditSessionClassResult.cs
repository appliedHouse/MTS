using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AuditSessionClassResult
{
    public int AuditSessionResultId { get; set; }

    public int AssetFormAuditSessionId { get; set; }

    public int AuditLocation { get; set; }

    public int ClassId { get; set; }

    public int NoOfRegistred { get; set; }

    public int TotalAssetFound { get; set; }

    public int InPlaceCount { get; set; }

    public int NotInPlaceCount { get; set; }

    public int NoOfMissing { get; set; }

    public int NoOfExtra { get; set; }

    public decimal? WeightOfRegisterd { get; set; }

    public decimal? WeightOfFound { get; set; }

    public decimal? WeightOfLost { get; set; }

    public virtual AssetFormAuditSession AssetFormAuditSession { get; set; } = null!;

    public virtual Location AuditLocationNavigation { get; set; } = null!;

    public virtual AssetsClassfication Class { get; set; } = null!;
}
