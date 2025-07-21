using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LastMonthProcessReportView
{
    public string UserName { get; set; } = null!;

    public int? ProcessCount { get; set; }

    public DateTime? LastDate { get; set; }

    public string? LastType { get; set; }
}
