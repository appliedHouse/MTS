using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class CustomFieldsDefinition
{
    public int FieldId { get; set; }

    public int ClassId { get; set; }

    public int TypeId { get; set; }

    public string? TitleAr { get; set; }

    public string? TitleEn { get; set; }

    public bool? IsRequired { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual AssetsClassfication Class { get; set; } = null!;

    public virtual ICollection<CustomFieldsOption> CustomFieldsOptions { get; set; } = new List<CustomFieldsOption>();

    public virtual ICollection<TempProcessCustomFieldDatum> TempProcessCustomFieldData { get; set; } = new List<TempProcessCustomFieldDatum>();

    public virtual LtcustomFieldsType Type { get; set; } = null!;
}
