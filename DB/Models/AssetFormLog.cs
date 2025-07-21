using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormLog
{
    public int FormLogId { get; set; }

    public int FormId { get; set; }

    public string? FormTitle { get; set; }

    public int FormProcessStateId { get; set; }

    public int? FormProcessedByUserId { get; set; }

    public string? Notes { get; set; }

    public Guid TransactionId { get; set; }

    public virtual AssetForm Form { get; set; } = null!;

    public virtual LtformProcessState FormProcessState { get; set; } = null!;

    public virtual UserAccount? FormProcessedByUser { get; set; }

    public virtual SystemTransaction Transaction { get; set; } = null!;
}
