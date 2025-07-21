using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class ClildernClassfication
{
    public int ClassId { get; set; }

    public int? ParentClassId { get; set; }

    public string ClassName { get; set; } = null!;

    public string? ParentClassPath { get; set; }

    public string? ClassCode { get; set; }

    public string ClassImage { get; set; } = null!;

    public string? LevelNodeCode { get; set; }

    public int? ClassLevelId { get; set; }

    public bool IsActiveForHandheld { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }
}
