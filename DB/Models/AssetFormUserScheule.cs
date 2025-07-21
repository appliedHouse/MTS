using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormUserScheule
{
    public int AssetFormUserSchudleId { get; set; }

    public int AssetFormId { get; set; }

    public int UserId { get; set; }

    public int DayId { get; set; }

    public TimeOnly FromTime { get; set; }

    public TimeOnly ToTime { get; set; }

    public virtual AssetForm AssetForm { get; set; } = null!;

    public virtual LtdayName Day { get; set; } = null!;

    public virtual UserAccount User { get; set; } = null!;
}
