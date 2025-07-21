using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class TempAssetEditTag
{
    public int TempAssetEditTagId { get; set; }

    public int ProcessId { get; set; }

    public string TagId { get; set; } = null!;

    public int TagTypeId { get; set; }

    public virtual TempProcessEditItem Process { get; set; } = null!;

    public virtual LtrfidtagType TagType { get; set; } = null!;
}
