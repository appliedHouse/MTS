using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class TempProcessReturnItem
{
    public int ProcessId { get; set; }

    public int TempProcessId { get; set; }

    public DateTime ProcessDate { get; set; }

    public int NewAssetStateId { get; set; }

    public int WarehouseLocationId { get; set; }

    public bool IsTransfer { get; set; }

    public bool IsPenddingState { get; set; }

    public virtual LtassetState NewAssetState { get; set; } = null!;

    public virtual TempProcess TempProcess { get; set; } = null!;

    public virtual ICollection<WarehousReturnFormItem> WarehousReturnFormItems { get; set; } = new List<WarehousReturnFormItem>();

    public virtual Location WarehouseLocation { get; set; } = null!;
}
