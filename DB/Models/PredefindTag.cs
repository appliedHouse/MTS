using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class PredefindTag
{
    public int PredefindTagId { get; set; }

    public string TagId { get; set; } = null!;

    public int TagTypeId { get; set; }

    public string? Tid { get; set; }

    public bool IsUsed { get; set; }

    public DateTime AddedDate { get; set; }

    public string AddedBy { get; set; } = null!;
}
