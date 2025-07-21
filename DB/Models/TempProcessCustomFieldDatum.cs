using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class TempProcessCustomFieldDatum
{
    public int TempValueId { get; set; }

    public int AssetRegistrationProcessId { get; set; }

    public int FieldId { get; set; }

    public string? TitleAr { get; set; }

    public string? TitleEn { get; set; }

    public string? FieldValue { get; set; }

    public virtual TempProcessRegistrationItem AssetRegistrationProcess { get; set; } = null!;

    public virtual CustomFieldsDefinition Field { get; set; } = null!;
}
