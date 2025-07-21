using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class TempProcess
{
    public int TempProcessId { get; set; }

    public string? Title { get; set; }

    public DateTime ProcessDate { get; set; }

    public int ProcessType { get; set; }

    public int ProcessStatus { get; set; }

    public int? WarehouseFormId { get; set; }

    public int AddedBy { get; set; }

    public int? TakenBy { get; set; }

    public int ItemsQuantity { get; set; }

    public int FinshedQuantity { get; set; }

    public string? Notes { get; set; }

    public virtual UserAccount AddedByNavigation { get; set; } = null!;

    public virtual ICollection<AssetFormEndLifeItem> AssetFormEndLifeItems { get; set; } = new List<AssetFormEndLifeItem>();

    public virtual ICollection<AssetForm> AssetForms { get; set; } = new List<AssetForm>();

    public virtual LtprocessState ProcessStatusNavigation { get; set; } = null!;

    public virtual LtprocessType ProcessTypeNavigation { get; set; } = null!;

    public virtual UserAccount? TakenByNavigation { get; set; }

    public virtual ICollection<TempProcessEditItem> TempProcessEditItems { get; set; } = new List<TempProcessEditItem>();

    public virtual ICollection<TempProcessGuardenItem> TempProcessGuardenItems { get; set; } = new List<TempProcessGuardenItem>();

    public virtual ICollection<TempProcessLog> TempProcessLogs { get; set; } = new List<TempProcessLog>();

    public virtual ICollection<TempProcessMaintenanceItem> TempProcessMaintenanceItems { get; set; } = new List<TempProcessMaintenanceItem>();

    public virtual ICollection<TempProcessRegeofencingItem> TempProcessRegeofencingItems { get; set; } = new List<TempProcessRegeofencingItem>();

    public virtual ICollection<TempProcessRegistrationItemLog> TempProcessRegistrationItemLogs { get; set; } = new List<TempProcessRegistrationItemLog>();

    public virtual ICollection<TempProcessRegistrationItem> TempProcessRegistrationItems { get; set; } = new List<TempProcessRegistrationItem>();

    public virtual ICollection<TempProcessReturnItem> TempProcessReturnItems { get; set; } = new List<TempProcessReturnItem>();

    public virtual ICollection<TempProcessTransferItem> TempProcessTransferItems { get; set; } = new List<TempProcessTransferItem>();

    public virtual WarehouseForm? WarehouseForm { get; set; }
}
