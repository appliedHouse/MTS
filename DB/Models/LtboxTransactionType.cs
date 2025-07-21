using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtboxTransactionType
{
    public int BoxTransactionTypeId { get; set; }

    public string BoxTransactionTypeName { get; set; } = null!;

    public bool NeedToRemove { get; set; }

    public virtual ICollection<AssetFormBoxTransaction> AssetFormBoxTransactions { get; set; } = new List<AssetFormBoxTransaction>();
}
