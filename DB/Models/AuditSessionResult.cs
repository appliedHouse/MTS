using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AuditSessionResult
{
    public int AuditSessionResultId { get; set; }

    public int AssetFormAuditSessionId { get; set; }

    public int AuditLocation { get; set; }

    public DateTime AuditDate { get; set; }

    public int NoOfRegistred { get; set; }

    public int TotalAssetFound { get; set; }

    public int InPlaceCount { get; set; }

    public int NotInPlaceCount { get; set; }

    public int NoOfMissing { get; set; }

    public int NoOfExtra { get; set; }

    public virtual AssetFormAuditSession AssetFormAuditSession { get; set; } = null!;

    public virtual Location AuditLocationNavigation { get; set; } = null!;
}
