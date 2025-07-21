using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetFormAddTagItem
{
    public int AssetFormAddTagItemId { get; set; }

    public int AssetFormId { get; set; }

    public int AssetId { get; set; }

    public int? AssetTransactionId { get; set; }

    public int? ProcessId { get; set; }
}
