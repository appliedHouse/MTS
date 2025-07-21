using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetWarehouse
{
    public int AssetWarehouseId { get; set; }

    public int AssetId { get; set; }

    public int WarehouseFormId { get; set; }

    public DateOnly RegisterDate { get; set; }

    public bool IsCurrentForm { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual WarehouseForm WarehouseForm { get; set; } = null!;
}
