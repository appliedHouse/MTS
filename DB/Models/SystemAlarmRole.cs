using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class SystemAlarmRole
{
    public int SystemAlarmRoleId { get; set; }

    public double ReadingGateSensitivety { get; set; }

    public double NearstReaderChangeSensitivety { get; set; }

    public int NumberToBeSureForNearstReader { get; set; }

    public int TimeToLost { get; set; }

    public int TimeToMotion { get; set; }

    public int TimeToNotDetected { get; set; }

    public int SystemRunningMode { get; set; }

    public bool AlarmIfzoneChange { get; set; }

    public bool AlarmIfunAuthZonePass { get; set; }

    public bool AlarmIfgatePass { get; set; }

    public bool AlarmIfroomLocatorChange { get; set; }

    public bool AlarmIfnearstReaderChange { get; set; }

    public bool RepeatAlarmIfzoneChange { get; set; }

    public bool RepeatAlarmIfunAuthZonePass { get; set; }

    public bool RepeatAlarmIfgatePass { get; set; }

    public bool RepeatAlarmIfroomLocatorChange { get; set; }

    public bool RepeatAlarmIfnearstReaderChange { get; set; }

    public bool AlarmIflost { get; set; }

    public bool AlarmIfunCovered { get; set; }

    public bool AlarmIfmotion { get; set; }

    public bool AlarmIftamper { get; set; }

    public bool AlarmIfnotDetected { get; set; }

    public bool AlarmIfpanic { get; set; }

    public bool SirenOnLost { get; set; }

    public bool SirenOnMotion { get; set; }

    public bool SirenOnZoneChange { get; set; }

    public bool SirenOnLocationChange { get; set; }

    public bool SirenOnTamper { get; set; }

    public bool SirenOnNotDetected { get; set; }

    public bool SirenOnUnAuthZone { get; set; }

    public bool SirenOnGate { get; set; }

    public bool SirenOnPanic { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual SystemTransaction? UpdateTransaction { get; set; }
}
