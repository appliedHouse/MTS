using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtprocessUserAction
{
    public int ProcessUserActionId { get; set; }

    public int ProcessUserActionValue { get; set; }

    public string ProcessUserActionKey { get; set; } = null!;

    public virtual ICollection<TempProcessLog> TempProcessLogs { get; set; } = new List<TempProcessLog>();
}
