using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtprocessType
{
    public int ProcessTypeId { get; set; }

    public string ProcessTypKey { get; set; } = null!;

    public int? ServiceId { get; set; }

    public virtual ICollection<AssetForm> AssetForms { get; set; } = new List<AssetForm>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogs { get; set; } = new List<AssetTransactionLog>();

    public virtual ICollection<LtassetTransferReason> LtassetTransferReasons { get; set; } = new List<LtassetTransferReason>();

    public virtual ICollection<ProcessedAssetForm> ProcessedAssetForms { get; set; } = new List<ProcessedAssetForm>();

    public virtual SystemService? Service { get; set; }

    public virtual ICollection<TempProcessLog> TempProcessLogs { get; set; } = new List<TempProcessLog>();

    public virtual ICollection<TempProcess> TempProcesses { get; set; } = new List<TempProcess>();

    public virtual ICollection<UserProcessType> UserProcessTypes { get; set; } = new List<UserProcessType>();
}
