using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class TempProcessLog
{
    public int ProcessLogId { get; set; }

    public int ProcessId { get; set; }

    public DateTime ProcessLogDate { get; set; }

    public int ProcessType { get; set; }

    public int ProcessStatus { get; set; }

    public int ProcessUserActionId { get; set; }

    public int FinshedQuantity { get; set; }

    public int? ForUserId { get; set; }

    public int UserId { get; set; }

    public string? Note { get; set; }

    public virtual UserAccount? ForUser { get; set; }

    public virtual TempProcess Process { get; set; } = null!;

    public virtual LtprocessState ProcessStatusNavigation { get; set; } = null!;

    public virtual LtprocessType ProcessTypeNavigation { get; set; } = null!;

    public virtual LtprocessUserAction ProcessUserAction { get; set; } = null!;

    public virtual UserAccount User { get; set; } = null!;
}
