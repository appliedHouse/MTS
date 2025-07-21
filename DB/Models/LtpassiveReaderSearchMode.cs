using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtpassiveReaderSearchMode
{
    public int SearchModeId { get; set; }

    public string SearchModeKey { get; set; } = null!;

    public virtual ICollection<RfidpassiveReader> RfidpassiveReaders { get; set; } = new List<RfidpassiveReader>();
}
