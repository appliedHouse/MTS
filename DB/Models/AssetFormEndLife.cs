using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormEndLife
{
    public int AssetFormId { get; set; }

    public int DestructionTypeId { get; set; }

    public int? EmployeeId { get; set; }

    public string? RecieverName { get; set; }

    public int? LocationId { get; set; }

    public string? SiteName { get; set; }

    public string Reason { get; set; } = null!;

    public virtual AssetForm AssetForm { get; set; } = null!;

    public virtual ICollection<AssetFormEndLifeItem> AssetFormEndLifeItems { get; set; } = new List<AssetFormEndLifeItem>();

    public virtual LtdestructionType DestructionType { get; set; } = null!;
}
