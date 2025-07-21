using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtcustomFieldsType
{
    public int TypeId { get; set; }

    public string? TitleAr { get; set; }

    public string? TitleEn { get; set; }

    public string? SystemType { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<CustomFieldsDefinition> CustomFieldsDefinitions { get; set; } = new List<CustomFieldsDefinition>();
}
