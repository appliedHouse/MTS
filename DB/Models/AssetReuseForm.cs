using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetReuseForm
{
    public int AssetReuseFormId { get; set; }

    public DateTime FormDate { get; set; }

    public string? FormNote { get; set; }

    public string? RequestOrigine { get; set; }

    public string? ReuseResone { get; set; }

    public int? WarehouseEmployeeId { get; set; }

    public int? WarehouseManagerId { get; set; }

    public int? Gmid { get; set; }

    public int? OldLocationId { get; set; }

    public int? RequestOrigineEmployeeId { get; set; }

    public int CurrentGurdianshipId { get; set; }

    public int UserId { get; set; }

    public virtual Employee CurrentGurdianship { get; set; } = null!;

    public virtual Location? OldLocation { get; set; }

    public virtual Employee? RequestOrigineEmployee { get; set; }

    public virtual UserAccount User { get; set; } = null!;
}
