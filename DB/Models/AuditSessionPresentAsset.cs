using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AuditSessionPresentAsset
{
    public int AuditSessionPresentId { get; set; }

    public int AssetFormAuditSessionId { get; set; }

    public int AssetId { get; set; }

    public int? AssetTransactionId { get; set; }

    public int LocationId { get; set; }

    public int? UserId { get; set; }

    public DateTime? AuditDate { get; set; }

    public bool IsFound { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual AssetFormAuditSession AssetFormAuditSession { get; set; } = null!;

    public virtual AssetTransactionLog? AssetTransaction { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual UserAccount? User { get; set; }
}
