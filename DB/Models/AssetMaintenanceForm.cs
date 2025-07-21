using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetMaintenanceForm
{
    public int AssetMaintenanceFormId { get; set; }

    public DateTime MaintananceDate { get; set; }

    public DateTime? ExpectedReturnDate { get; set; }

    public int MaintenanceLocationId { get; set; }

    public int? MaintenanceTypeId { get; set; }

    public int SupervisorId { get; set; }

    public virtual ICollection<AssetFormMaintenanceItem> AssetFormMaintenanceItems { get; set; } = new List<AssetFormMaintenanceItem>();

    public virtual AssetForm AssetMaintenanceFormNavigation { get; set; } = null!;

    public virtual Location MaintenanceLocation { get; set; } = null!;

    public virtual LtmaintenanceType? MaintenanceType { get; set; }

    public virtual Employee Supervisor { get; set; } = null!;
}
