using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LocationArea
{
    public string AreaId { get; set; } = null!;

    public string AreaName { get; set; } = null!;

    public DateTime AddedDate { get; set; }
}
