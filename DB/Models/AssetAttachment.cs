using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetAttachment
{
    public int AssetAttachmentId { get; set; }

    public int AssetId { get; set; }

    public string AttachmentFileName { get; set; } = null!;

    public string AttachmentFilePath { get; set; } = null!;

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual Asset Asset { get; set; } = null!;

    public virtual SystemTransaction? UpdateTransaction { get; set; }
}
