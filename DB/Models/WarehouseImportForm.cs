using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class WarehouseImportForm
{
    public int WarehouseFormId { get; set; }

    public int RecipiantEmployeeId { get; set; }

    public virtual Employee RecipiantEmployee { get; set; } = null!;

    public virtual WarehouseForm WarehouseForm { get; set; } = null!;
}
