using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class UserAccessLocation
{
    public int UserAccesLocationId { get; set; }

    public int UserId { get; set; }

    public int LocationId { get; set; }

    public Guid TransactionId { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual SystemTransaction Transaction { get; set; } = null!;

    public virtual UserAccount User { get; set; } = null!;
}
