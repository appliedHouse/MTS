using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AlarmActiveAsset
{
    public Guid AlarmId { get; set; }

    public int AssetId { get; set; }

    public string TagId { get; set; } = null!;

    public int? GurdianshipId { get; set; }

    public int? ReaderId { get; set; }

    public string? ReadingAntennaName { get; set; }

    public int? ReadingSsi { get; set; }

    public int? AntennaASsi { get; set; }

    public int? AntennaBSsi { get; set; }

    public int? RoomLocatorId { get; set; }

    public double? Xposition { get; set; }

    public double? Yposition { get; set; }

    public virtual Alarm Alarm { get; set; } = null!;

    public virtual Asset Asset { get; set; } = null!;

    public virtual Employee? Gurdianship { get; set; }

    public virtual Hardware? Reader { get; set; }

    public virtual RfidactiveReader? ReaderNavigation { get; set; }

    public virtual RfidroomLocator? RoomLocator { get; set; }
}
