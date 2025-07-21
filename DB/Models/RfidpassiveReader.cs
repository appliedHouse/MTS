using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class RfidpassiveReader
{
    public int HardwareId { get; set; }

    public string ReaderName { get; set; } = null!;

    public int ReaderType { get; set; }

    public int ReaderModel { get; set; }

    public string? ReaderDescription { get; set; }

    public int ConnectedAntenna { get; set; }

    public int ReceiveTimeout { get; set; }

    public int SendTimeout { get; set; }

    public int NoOfTriesToConnectB4disabling { get; set; }

    public int TimeB4tryToConnect { get; set; }

    public int ReadingSession { get; set; }

    public int? TotalTime { get; set; }

    public int? WorkTime { get; set; }

    public int SearchMode { get; set; }

    public int DelaybeforeWorkTime { get; set; }

    public double? DefaultTx { get; set; }

    public double? DefaultRx { get; set; }

    public string? TxFrequenciesInMhz { get; set; }

    public virtual ICollection<AlarmPassiveAsset> AlarmPassiveAssets { get; set; } = new List<AlarmPassiveAsset>();

    public virtual ICollection<EmployeeTrackingLog> EmployeeTrackingLogs { get; set; } = new List<EmployeeTrackingLog>();

    public virtual ICollection<EmployeeTracking> EmployeeTrackings { get; set; } = new List<EmployeeTracking>();

    public virtual Hardware Hardware { get; set; } = null!;

    public virtual LthardwareModel ReaderModelNavigation { get; set; } = null!;

    public virtual LtreaderFunction ReaderTypeNavigation { get; set; } = null!;

    public virtual ICollection<Rfidantenna> Rfidantennas { get; set; } = new List<Rfidantenna>();

    public virtual LtpassiveReaderSearchMode SearchModeNavigation { get; set; } = null!;
}
