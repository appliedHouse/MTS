using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtsystemAppType
{
    public int SystemAppTypeId { get; set; }

    public string SystemAppKey { get; set; } = null!;

    public virtual ICollection<SystemApp> SystemApps { get; set; } = new List<SystemApp>();
}
