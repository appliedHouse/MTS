using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class SystemTagFilter
{
    public int TagFilterId { get; set; }

    public string TagFilter { get; set; } = null!;

    public string TagFilterDescription { get; set; } = null!;

    public bool IsHardwareFilter { get; set; }

    public bool IsSoftwareFilter { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public bool IsActive { get; set; }

    public DateTime LastUpdateDate { get; set; }
}
