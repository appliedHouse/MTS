using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormEditTag
{
    public int AssetFormEditTagId { get; set; }

    public int AssetFormId { get; set; }

    public int? AssetTagId { get; set; }

    public string TagId { get; set; } = null!;

    public int AssetTypeId { get; set; }

    public string? Tid { get; set; }

    public virtual AssetForm AssetForm { get; set; } = null!;

    public virtual LtrfidtagType AssetType { get; set; } = null!;
}
