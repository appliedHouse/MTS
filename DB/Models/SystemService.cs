using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class SystemService
{
    public int ServiceId { get; set; }

    public int? ParentServiceId { get; set; }

    public string ServiceName { get; set; } = null!;

    public string? ControllerName { get; set; }

    public string? ActionName { get; set; }

    public string IconPath { get; set; } = null!;

    public int ServiceGroupId { get; set; }

    public int SortOrder { get; set; }

    public bool IsActive { get; set; }

    public bool IsActiveForPrivalage { get; set; }

    public bool IsRoot { get; set; }

    public string? Shortcut { get; set; }

    public bool IsHasForm { get; set; }

    public bool IsMenuItem { get; set; }

    public bool Istile { get; set; }

    public virtual ICollection<FormSign> FormSigns { get; set; } = new List<FormSign>();

    public virtual ICollection<GroupPrivilege> GroupPrivileges { get; set; } = new List<GroupPrivilege>();

    public virtual ICollection<LocalizationString> LocalizationStrings { get; set; } = new List<LocalizationString>();

    public virtual ICollection<LtprocessType> LtprocessTypes { get; set; } = new List<LtprocessType>();
}
