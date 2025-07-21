using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class EmployeeTrackingLog
{
    public int EmployeeTrackingLogId { get; set; }

    public DateTime EnteranceDate { get; set; }

    public int EmployeeId { get; set; }

    public int LocationId { get; set; }

    public int? ZoneId { get; set; }

    public int ReaderId { get; set; }

    public int AntennaId { get; set; }

    public int AntennaFunctionId { get; set; }

    public int ReadingSsi { get; set; }

    public double? Xposition { get; set; }

    public double? Yposition { get; set; }

    public virtual Rfidantenna Antenna { get; set; } = null!;

    public virtual LtantennaFunction AntennaFunction { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual RfidpassiveReader Reader { get; set; } = null!;

    public virtual Zone? Zone { get; set; }
}
