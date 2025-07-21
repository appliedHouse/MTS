using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormSaleFin
{
    public int AssetFormSaleFinId { get; set; }

    public int FinVoucherId { get; set; }

    public int BranchId { get; set; }

    public DateTime AddedDate { get; set; }

    public int AddedBy { get; set; }

    public virtual AssetFormSale AssetFormSaleFinNavigation { get; set; } = null!;
}
