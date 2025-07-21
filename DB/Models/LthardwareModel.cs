using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LthardwareModel
{
    public int HardwareModelId { get; set; }

    public string HardwareModelName { get; set; } = null!;

    public int HardwareTypeId { get; set; }

    public virtual LthardwareType HardwareType { get; set; } = null!;

    public virtual ICollection<RfidpassiveReader> RfidpassiveReaders { get; set; } = new List<RfidpassiveReader>();
}
