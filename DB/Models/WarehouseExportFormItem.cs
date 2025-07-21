using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class WarehouseExportFormItem
{
    public int ReciveFormItemId { get; set; }

    public int AssetClassId { get; set; }

    public int Quantity { get; set; }

    public int Unit { get; set; }

    public int WarehouseFormId { get; set; }

    public virtual AssetsClassfication AssetClass { get; set; } = null!;

    public virtual LtassetUnit UnitNavigation { get; set; } = null!;

    public virtual WarehouseForm WarehouseForm { get; set; } = null!;
}
