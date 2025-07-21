using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class UserProfileFavClass
{
    public int UserProfileFavClassId { get; set; }

    public int UserId { get; set; }

    public int ClassId { get; set; }

    public virtual AssetsClassfication Class { get; set; } = null!;

    public virtual UserAccount User { get; set; } = null!;
}
