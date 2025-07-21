using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LthardwareType
{
    public int HardwareTypeId { get; set; }

    public string HardwareType { get; set; } = null!;

    public virtual ICollection<Hardware> Hardwares { get; set; } = new List<Hardware>();

    public virtual ICollection<LthardwareModel> LthardwareModels { get; set; } = new List<LthardwareModel>();

    public virtual ICollection<LtreaderFunction> LtreaderFunctions { get; set; } = new List<LtreaderFunction>();
}
