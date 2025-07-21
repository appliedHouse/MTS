using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class UserProfileFavLocation
{
    public int UserProfileFavLocationId { get; set; }

    public int UserId { get; set; }

    public int LocationId { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual UserAccount User { get; set; } = null!;
}
