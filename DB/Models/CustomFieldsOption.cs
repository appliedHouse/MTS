using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class CustomFieldsOption
{
    public int FieldOptionId { get; set; }

    public int FieldId { get; set; }

    public string? TitleAr { get; set; }

    public string? TitleEn { get; set; }

    public virtual CustomFieldsDefinition Field { get; set; } = null!;
}
