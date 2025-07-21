using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LocationDoorArmingTime
{
    public int DoorArmingId { get; set; }

    public int ArmDateOfWeek { get; set; }

    public TimeOnly AmrTimeFrom { get; set; }

    public TimeOnly ArmTimeTo { get; set; }

    public int DoorId { get; set; }

    public virtual LocationDoor Door { get; set; } = null!;
}
