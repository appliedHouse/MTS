using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Zone
{
    public int ZoneId { get; set; }

    public string ZoneName { get; set; } = null!;

    public bool IsActive { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual ICollection<Alarm> Alarms { get; set; } = new List<Alarm>();

    public virtual ICollection<AssetAlarmRole> AssetAlarmRoles { get; set; } = new List<AssetAlarmRole>();

    public virtual ICollection<AssetFormAlarmRoleItem> AssetFormAlarmRoleItems { get; set; } = new List<AssetFormAlarmRoleItem>();

    public virtual ICollection<AssetTracking> AssetTrackings { get; set; } = new List<AssetTracking>();

    public virtual ICollection<EmployeeTrackingLog> EmployeeTrackingLogs { get; set; } = new List<EmployeeTrackingLog>();

    public virtual ICollection<EmployeeTracking> EmployeeTrackings { get; set; } = new List<EmployeeTracking>();

    public virtual ICollection<Hardware> Hardwares { get; set; } = new List<Hardware>();

    public virtual ICollection<SystemCore> SystemCores { get; set; } = new List<SystemCore>();

    public virtual SystemTransaction? UpdateTransaction { get; set; }

    public virtual ICollection<ZoneLocation> ZoneLocations { get; set; } = new List<ZoneLocation>();
}
