using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class WarehouseForm
{
    public int FormId { get; set; }

    public int WarehouseLocationId { get; set; }

    public int WarehouseManagerId { get; set; }

    public int WarehousesSheriffId { get; set; }

    public virtual ICollection<AssetWarehouse> AssetWarehouses { get; set; } = new List<AssetWarehouse>();

    public virtual AssetForm Form { get; set; } = null!;

    public virtual ICollection<TempProcess> TempProcesses { get; set; } = new List<TempProcess>();

    public virtual ICollection<WarehousReturnFormItem> WarehousReturnFormItems { get; set; } = new List<WarehousReturnFormItem>();

    public virtual WarehouseExportForm? WarehouseExportForm { get; set; }

    public virtual ICollection<WarehouseExportFormItem> WarehouseExportFormItems { get; set; } = new List<WarehouseExportFormItem>();

    public virtual WarehouseImportForm? WarehouseImportForm { get; set; }

    public virtual ICollection<WarehouseImportFormItem> WarehouseImportFormItems { get; set; } = new List<WarehouseImportFormItem>();

    public virtual Location WarehouseLocation { get; set; } = null!;

    public virtual Employee WarehouseManager { get; set; } = null!;

    public virtual Employee WarehousesSheriff { get; set; } = null!;
}
