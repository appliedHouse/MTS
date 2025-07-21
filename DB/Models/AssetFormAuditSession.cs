using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormAuditSession
{
    public int AssetFormAuditSessionId { get; set; }

    public string SessionName { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? ClosedByUser { get; set; }

    public int AuditStatusId { get; set; }

    public int AuditSessionTypeId { get; set; }

    public int AuditLocationId { get; set; }

    public virtual AssetForm AssetFormAuditSessionNavigation { get; set; } = null!;

    public virtual Location AuditLocation { get; set; } = null!;

    public virtual ICollection<AuditSessionClassResult> AuditSessionClassResults { get; set; } = new List<AuditSessionClassResult>();

    public virtual ICollection<AuditSessionPresentAsset> AuditSessionPresentAssets { get; set; } = new List<AuditSessionPresentAsset>();

    public virtual ICollection<AuditSessionResult> AuditSessionResults { get; set; } = new List<AuditSessionResult>();

    public virtual LtauditSessionType AuditSessionType { get; set; } = null!;

    public virtual LtauditSessionStatus AuditStatus { get; set; } = null!;

    public virtual UserAccount? ClosedByUserNavigation { get; set; }
}
