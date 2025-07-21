using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtsystemEntity
{
    public int EntityId { get; set; }

    public string EntityName { get; set; } = null!;

    public virtual ICollection<LocalizationString> LocalizationStrings { get; set; } = new List<LocalizationString>();
}
