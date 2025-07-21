using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class TempAssetTag
{
    public int TempAssetTagId { get; set; }

    public int ProcessId { get; set; }

    public string TagId { get; set; } = null!;

    public int TagTypeId { get; set; }

    public string? Tid { get; set; }

    public virtual TempProcessRegistrationItem Process { get; set; } = null!;

    public virtual LtrfidtagType TagType { get; set; } = null!;
}
