using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class ReportInfo
{
    public int ReportId { get; set; }

    public string ReportName { get; set; } = null!;

    public string? ReportAppLogo { get; set; }

    public string? ReportCustomerLogo { get; set; }
}
