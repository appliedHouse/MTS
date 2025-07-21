using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtsaleCancelReason
{
    public int SalCancelReason { get; set; }

    public string SalCancelReasonKey { get; set; } = null!;
}
