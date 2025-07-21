using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class IsPrivateCfvtag
{
    public string TagId { get; set; } = null!;

    public string IsPrivate { get; set; } = null!;

    public string? Expr1 { get; set; }

    public int? AssetId { get; set; }

    public int? AssetId2 { get; set; }

    public string? TitleAr { get; set; }

    public string? TitleEn { get; set; }

    public string? FieldValue { get; set; }

    public DateOnly? LastUpdatedTime { get; set; }
}
