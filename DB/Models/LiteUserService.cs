using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LiteUserService
{
    public int LiteServiceId { get; set; }

    public int ServiceId { get; set; }

    public int UserId { get; set; }

    public Guid AdeddTransactionId { get; set; }

    public virtual SystemTransaction AdeddTransaction { get; set; } = null!;

    public virtual LiteService Service { get; set; } = null!;

    public virtual UserAccount User { get; set; } = null!;
}
