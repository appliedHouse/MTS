using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class CustomFieldsValue
{
    public int FieldValueId { get; set; }

    public int FieldId { get; set; }

    public int AssetId { get; set; }

    public string? TitleAr { get; set; }

    public string? TitleEn { get; set; }

    public string? FieldValue { get; set; }

    public DateOnly? LastUpdatedTime { get; set; }

    public virtual Asset Asset { get; set; } = null!;
}
