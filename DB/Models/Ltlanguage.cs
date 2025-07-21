using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Ltlanguage
{
    public int LanguageId { get; set; }

    public string LanguageNativeName { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public bool IsDefault { get; set; }

    public string? FlagPath { get; set; }

    public virtual ICollection<LocalizationString> LocalizationStrings { get; set; } = new List<LocalizationString>();

    public virtual ICollection<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();
}
