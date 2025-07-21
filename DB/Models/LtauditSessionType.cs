using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtauditSessionType
{
    public int AuditSessionTypeId { get; set; }

    public string AuditSessionTypeName { get; set; } = null!;

    public virtual ICollection<AssetFormAuditSession> AssetFormAuditSessions { get; set; } = new List<AssetFormAuditSession>();
}
