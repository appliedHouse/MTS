using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class WarehouseExportForm
{
    public int WarehouseFormId { get; set; }

    public int RequestLocationId { get; set; }

    public int RequestManagerId { get; set; }

    public int RecipiantEmployeeId { get; set; }

    public virtual Employee RecipiantEmployee { get; set; } = null!;

    public virtual Location RequestLocation { get; set; } = null!;

    public virtual Employee RequestManager { get; set; } = null!;

    public virtual WarehouseForm WarehouseForm { get; set; } = null!;
}
