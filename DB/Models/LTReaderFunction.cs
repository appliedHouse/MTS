using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtreaderFunction
{
    public int ReaderFunctionId { get; set; }

    public string ReaderFunctionKey { get; set; } = null!;

    public int ISolisFunctionId { get; set; }

    public int? HardwareTypeId { get; set; }

    public virtual LthardwareType? HardwareType { get; set; }

    public virtual ICollection<RfidactiveReader> RfidactiveReaders { get; set; } = new List<RfidactiveReader>();

    public virtual ICollection<RfidpassiveReader> RfidpassiveReaders { get; set; } = new List<RfidpassiveReader>();
}
