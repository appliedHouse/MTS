using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class GetGuardianShip
{
    public int AssetId { get; set; }

    public int? NewEmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? AssetName { get; set; }

    public int? FormId { get; set; }

    public string? FormTitle { get; set; }

    public int GurdianshipFormId { get; set; }

    public string? TagId { get; set; }
}
