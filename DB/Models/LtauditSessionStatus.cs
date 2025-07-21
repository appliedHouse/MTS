using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtauditSessionStatus
{
    public int AuditSessionStatusId { get; set; }

    public string AuditSessionStatusName { get; set; } = null!;

    public virtual ICollection<AssetFormAuditSession> AssetFormAuditSessions { get; set; } = new List<AssetFormAuditSession>();
}
