using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Temp4
{
    public int LocationTypeId { get; set; }

    public string? LocationTypeText { get; set; }

    public int LocationId { get; set; }

    public int? ParentLocationId { get; set; }

    public string LocationName { get; set; } = null!;

    public string? LocationNameEn { get; set; }

    public int Type2 { get; set; }

    public string? LocationCode { get; set; }

    public string? LevelNodeCode { get; set; }

    public string? LocationParentPath { get; set; }

    public string? AreaId { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public bool IsDeleted { get; set; }

    public int? RefId { get; set; }

    public string? RefCode { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public int? TypeId3 { get; set; }

    public string? TypeText3 { get; set; }
}
