using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtprocessState
{
    public int ProcessStatusId { get; set; }

    public int ProcessStatusValue { get; set; }

    public string ProcessStatusKey { get; set; } = null!;

    public virtual ICollection<TempProcessLog> TempProcessLogs { get; set; } = new List<TempProcessLog>();

    public virtual ICollection<TempProcess> TempProcesses { get; set; } = new List<TempProcess>();
}
