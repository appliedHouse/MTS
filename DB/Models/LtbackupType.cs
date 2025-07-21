using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtbackupType
{
    public int BackupTypeId { get; set; }

    public int BackupTypeName { get; set; }

    public virtual ICollection<LocalizationString> LocalizationStrings { get; set; } = new List<LocalizationString>();
}
