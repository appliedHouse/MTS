using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class ProcessedAssetFormLog
{
    public int ProcessedAssetFormLog1 { get; set; }

    public int ProcessedAssetFormId { get; set; }

    public string Title { get; set; } = null!;

    public DateTime FormDate { get; set; }

    public int ProcessedBy { get; set; }

    public int ProcessedFormStatusId { get; set; }

    public string? Notes { get; set; }

    public virtual ProcessedAssetForm ProcessedAssetForm { get; set; } = null!;

    public virtual UserAccount ProcessedByNavigation { get; set; } = null!;
}
