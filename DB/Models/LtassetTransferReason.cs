using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtassetTransferReason
{
    public int AssetTransferReasonId { get; set; }

    public string AssetTransferReasonKey { get; set; } = null!;

    public int? ProccessTypeId { get; set; }

    public bool IsActive { get; set; }

    public bool IsLiteValue { get; set; }

    public bool IsDisableTracking { get; set; }

    public virtual ICollection<AssetForm> AssetForms { get; set; } = new List<AssetForm>();

    public virtual ICollection<AssetTransactionLog> AssetTransactionLogs { get; set; } = new List<AssetTransactionLog>();

    public virtual LtprocessType? ProccessType { get; set; }
}
