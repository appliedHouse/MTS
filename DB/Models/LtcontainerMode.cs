using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtcontainerMode
{
    public int ContainerModeId { get; set; }

    public string ContainerModeKey { get; set; } = null!;

    public virtual ICollection<AssetsClassProfile> AssetsClassProfiles { get; set; } = new List<AssetsClassProfile>();
}
