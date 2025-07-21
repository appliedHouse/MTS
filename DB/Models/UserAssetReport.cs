using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class UserAssetReport
{
    public int UserAssetReportId { get; set; }

    public int UserId { get; set; }

    public string? ReportTitle { get; set; }

    public string? ReportPath { get; set; }

    public string? ReportNumber { get; set; }

    public int? FormId { get; set; }

    public DateTime AddedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AssetForm? Form { get; set; }

    public virtual UserAccount User { get; set; } = null!;
}
