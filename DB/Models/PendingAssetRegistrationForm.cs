using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class PendingAssetRegistrationForm
{
    public int PendingAssetRegistrationFormId { get; set; }

    public int RequestLocationId { get; set; }

    public int GurdianshipFormId { get; set; }

    public int Signs { get; set; }

    public string? RefrenceNo { get; set; }

    public DateTime AddedDate { get; set; }

    public string? Notes { get; set; }

    public Guid AddTransactionId { get; set; }
}
