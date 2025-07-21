using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LocalizationString
{
    public int LocalizationStringId { get; set; }

    public int EntityId { get; set; }

    public int ForginEntityId { get; set; }

    public int LanguageId { get; set; }

    public string Text { get; set; } = null!;

    public virtual LtsystemEntity Entity { get; set; } = null!;

    public virtual LtbackupType ForginEntity { get; set; } = null!;

    public virtual SystemService ForginEntityNavigation { get; set; } = null!;

    public virtual Ltlanguage Language { get; set; } = null!;
}
