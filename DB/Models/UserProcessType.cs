using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class UserProcessType
{
    public int UserProcessTypeId { get; set; }

    public int UserId { get; set; }

    public int ProcessTypeId { get; set; }

    public Guid TransactionId { get; set; }

    public virtual LtprocessType ProcessType { get; set; } = null!;

    public virtual SystemTransaction Transaction { get; set; } = null!;

    public virtual UserAccount User { get; set; } = null!;
}
