using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class SystemConfig
{
    public int SystemKeyId { get; set; }

    public string SystemKeyCode { get; set; } = null!;

    public string SystemKeyTitle { get; set; } = null!;

    public string SystemKeyTitleEn { get; set; } = null!;

    public string SystemKeyValue { get; set; } = null!;

    public string SystemKeyValueEn { get; set; } = null!;

    public bool IsSystemKey { get; set; }
}
