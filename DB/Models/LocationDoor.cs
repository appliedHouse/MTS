using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LocationDoor
{
    public int DoorId { get; set; }

    public string DoorTagId { get; set; } = null!;

    public string? DoorDescription { get; set; }

    public bool Disabled { get; set; }

    public string? DoorIrid { get; set; }

    public string? DoorPaincTagId { get; set; }

    public string? DoorIrtagId { get; set; }

    public int LocationId { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual ICollection<LocationDoorArmingTime> LocationDoorArmingTimes { get; set; } = new List<LocationDoorArmingTime>();
}
