using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtdayName
{
    public int DayId { get; set; }

    public string DayName { get; set; } = null!;

    public virtual ICollection<AssetFormUserScheule> AssetFormUserScheules { get; set; } = new List<AssetFormUserScheule>();

    public virtual ICollection<SirenRole> SirenRoles { get; set; } = new List<SirenRole>();

    public virtual ICollection<UserScheduleIlog> UserScheduleIlogs { get; set; } = new List<UserScheduleIlog>();

    public virtual ICollection<UserScheduleI> UserScheduleIs { get; set; } = new List<UserScheduleI>();
}
