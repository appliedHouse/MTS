using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class HardwareConnectionLog
{
    public int HardwareConnectionLogId { get; set; }

    public int HardwareId { get; set; }

    public int HardwareConnectionStateId { get; set; }

    public DateTime AddedDate { get; set; }

    public virtual LthardwareConnectionState HardwareConnectionState { get; set; } = null!;
}
