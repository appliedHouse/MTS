using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetAlarmRoleLog
{
    public int AssetRoleLogId { get; set; }

    public int AssetId { get; set; }

    public int AssetFormId { get; set; }

    public int GeofencingZoneId { get; set; }

    public double ReadingGateSensitivety { get; set; }

    public double NearstReaderChangeSensitivety { get; set; }

    public int NumberToBeSureForNearstReader { get; set; }

    public int TimeToMotion { get; set; }

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

    public int SirenOnLost { get; set; }

    public int SirenOnMotion { get; set; }

    public int SirenOnZoneChange { get; set; }

    public int SirenOnTamper { get; set; }

    public int SirenOnNotDetected { get; set; }

    public bool SirenOnUnAuthZone { get; set; }

    public bool SirenOnGate { get; set; }

    public bool SirenOnPanic { get; set; }

    public Guid AddTransactionId { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual Asset Asset { get; set; } = null!;

    public virtual AssetForm AssetForm { get; set; } = null!;
}
