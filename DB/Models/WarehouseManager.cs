using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class WarehouseManager
{
    public int WarehouseLocationId { get; set; }

    public int WarehouseManagerId { get; set; }

    public int WarehousesSheriffId { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual SystemTransaction? UpdateTransaction { get; set; }

    public virtual Location WarehouseLocation { get; set; } = null!;

    public virtual Employee WarehouseManagerNavigation { get; set; } = null!;

    public virtual Employee WarehousesSheriff { get; set; } = null!;
}
