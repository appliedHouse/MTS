using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class CfvTag
{
    public string? TagId { get; set; }

    public int? AssetId { get; set; }

    public int AssetId2 { get; set; }

    public string? TitleAr { get; set; }

    public string? TitleEn { get; set; }

    public string? FieldValue { get; set; }

    public DateOnly? LastUpdatedTime { get; set; }
}
