using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class SystemAssetStateRule
{
    public int CuurentStateId { get; set; }

    public int AllowedNewStateId { get; set; }

    public DateTime AddedDate { get; set; }

    public virtual LtassetState AllowedNewState { get; set; } = null!;

    public virtual LtassetState CuurentState { get; set; } = null!;
}
