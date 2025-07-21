using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Rfidantenna
{
    public int AntennaId { get; set; }

    public string AntennaName { get; set; } = null!;

    public double AntennaTx { get; set; }

    public double AntennaRx { get; set; }

    public int LocationId { get; set; }

    public bool IsEnabled { get; set; }

    public int AntennaFunction { get; set; }

    public int ConnectedReaderId { get; set; }

    public int ConnectedPort { get; set; }

    public bool IsConnected { get; set; }

    public string? ReferenceTagId { get; set; }

    public string? SerailNumber { get; set; }

    public int AntennaThreshold { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual ICollection<AlarmPassiveAsset> AlarmPassiveAssets { get; set; } = new List<AlarmPassiveAsset>();

    public virtual LtantennaFunction AntennaFunctionNavigation { get; set; } = null!;

    public virtual RfidpassiveReader ConnectedReader { get; set; } = null!;

    public virtual ICollection<EmployeeTrackingLog> EmployeeTrackingLogs { get; set; } = new List<EmployeeTrackingLog>();

    public virtual ICollection<EmployeeTracking> EmployeeTrackings { get; set; } = new List<EmployeeTracking>();

    public virtual Location Location { get; set; } = null!;

    public virtual SystemTransaction? UpdateTransaction { get; set; }
}
