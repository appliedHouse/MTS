using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LiteService
{
    public int ServiceId { get; set; }

    public int? ParentServiceId { get; set; }

    public string ServiceName { get; set; } = null!;

    public string? ServiceType { get; set; }

    public int DisplayOrder { get; set; }

    public bool IsActive { get; set; }

    public bool IsMenuItem { get; set; }

    public virtual ICollection<LiteService> InverseParentService { get; set; } = new List<LiteService>();

    public virtual ICollection<LiteUserService> LiteUserServices { get; set; } = new List<LiteUserService>();

    public virtual LiteService? ParentService { get; set; }
}
