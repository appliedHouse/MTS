using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetTagTransactionLog
{
    public int AssetTagTransactionId { get; set; }

    public int? AssetTransactionId { get; set; }

    public int AssetId { get; set; }

    public string TagId { get; set; } = null!;

    public int TagTypeId { get; set; }

    public string? Tid { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual AssetTransactionLog? AssetTransaction { get; set; }

    public virtual LtrfidtagType TagType { get; set; } = null!;
}
