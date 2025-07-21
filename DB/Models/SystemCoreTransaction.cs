using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class SystemCoreTransaction
{
    public Guid TransactionId { get; set; }

    public string? TransactionMessage { get; set; }

    public DateTime? TransactionDate { get; set; }

    public int? TransactionType { get; set; }

    public string? SystemIp { get; set; }

    public string? AppName { get; set; }
}
