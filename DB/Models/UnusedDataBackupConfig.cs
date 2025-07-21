using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class UnusedDataBackupConfig
{
    public int BackupJobId { get; set; }

    public string JobName { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? NextScheduledRun { get; set; }

    public string? BackupPath { get; set; }

    public bool IsEnabled { get; set; }

    public double Dbsize { get; set; }

    public int? BackupTypeId { get; set; }

    public int RerunEvery { get; set; }
}
