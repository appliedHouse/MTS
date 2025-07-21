using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtdestructionType
{
    public int DestructionTypeId { get; set; }

    public string DestructionReasonKey { get; set; } = null!;

    public bool IsByEmployee { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<AssetFormEndLife> AssetFormEndLives { get; set; } = new List<AssetFormEndLife>();
}
