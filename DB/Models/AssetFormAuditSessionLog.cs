using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormAuditSessionLog
{
    public int AssetFormAuditSessionLog1 { get; set; }

    public int AssetFormAuditSessionId { get; set; }

    public string SessionName { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? ClosedByUser { get; set; }

    public int AuditStatusId { get; set; }

    public int AuditSessionTypeId { get; set; }

    public int AuditLocationId { get; set; }

    public DateTime UpdatedDate { get; set; }
}
