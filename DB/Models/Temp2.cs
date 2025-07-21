using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Temp2
{
    public string TagId { get; set; } = null!;

    public string ClassCode { get; set; } = null!;

    public int ClassId { get; set; }

    public int AssetId { get; set; }

    public int? ClassId2 { get; set; }

    public int? ParentClassId { get; set; }

    public string? ClassName { get; set; }

    public string? ClassNameEn { get; set; }

    public string? ParentClassPath { get; set; }

    public string? ClassCode2 { get; set; }

    public string? ClassImage { get; set; }

    public string? LevelNodeCode { get; set; }

    public int? ClassLevelId { get; set; }

    public bool? IsActiveForHandheld { get; set; }

    public Guid? AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RefId { get; set; }

    public DateTime? LastUpdateDate { get; set; }
}
