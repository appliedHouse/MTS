using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetsClassficationsLevel
{
    public int ClassLevelId { get; set; }

    public int LevelNumber { get; set; }

    public int LevelCodeDigits { get; set; }

    public virtual ICollection<AssetsClassfication> AssetsClassfications { get; set; } = new List<AssetsClassfication>();
}
