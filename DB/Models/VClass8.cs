using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class VClass8
{
    public string TagId { get; set; } = null!;

    public string ClassCode { get; set; } = null!;

    public int ClassId { get; set; }

    public int AssetId { get; set; }

    public int? AssetTagId { get; set; }

    public int? AssetId2 { get; set; }

    public string? TagId2 { get; set; }

    public int? TagTypeId { get; set; }

    public string? Tid { get; set; }
}
