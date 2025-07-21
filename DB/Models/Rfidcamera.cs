using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Rfidcamera
{
    public int HardwareId { get; set; }

    public string? CameraName { get; set; }

    public string CameraUsername { get; set; } = null!;

    public string CameraPassword { get; set; } = null!;

    public int RecordTime { get; set; }

    public bool WithTail { get; set; }

    public int? TailTime { get; set; }

    public bool? EnableMotionDetection { get; set; }

    public string? StoreLocation { get; set; }

    public int? PlaySoundAlarmTime { get; set; }

    public int? JoinWithReaderId { get; set; }

    public int CameraTypeId { get; set; }

    public virtual LtcameraType CameraType { get; set; } = null!;

    public virtual Hardware Hardware { get; set; } = null!;
}
