using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtantennaFunction
{
    public int AntennaFunctionId { get; set; }

    public string FunctionKey { get; set; } = null!;

    public int ISolisFunctionId { get; set; }

    public virtual ICollection<EmployeeTrackingLog> EmployeeTrackingLogs { get; set; } = new List<EmployeeTrackingLog>();

    public virtual ICollection<Rfidantenna> Rfidantennas { get; set; } = new List<Rfidantenna>();
}
