using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class ProcessedAssetForm
{
    public int ProcessedAssetFormId { get; set; }

    public int? ProcessedAssetFormParentId { get; set; }

    public string Title { get; set; } = null!;

    public string? ReportUrl { get; set; }

    public int AssetFormId { get; set; }

    public int ProccessTypeId { get; set; }

    public DateTime FormDate { get; set; }

    public int ProcessedBy { get; set; }

    public int AssetCount { get; set; }

    public int ProcessedFormStatusId { get; set; }

    public bool IsHidden { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<ProcessedAssetForm> InverseProcessedAssetFormParent { get; set; } = new List<ProcessedAssetForm>();

    public virtual LtprocessType ProccessType { get; set; } = null!;

    public virtual ICollection<ProcessedAssetFormLog> ProcessedAssetFormLogs { get; set; } = new List<ProcessedAssetFormLog>();

    public virtual ProcessedAssetForm? ProcessedAssetFormParent { get; set; }

    public virtual UserAccount ProcessedByNavigation { get; set; } = null!;

    public virtual LtformProcessState ProcessedFormStatus { get; set; } = null!;
}
