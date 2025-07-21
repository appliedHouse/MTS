using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtcameraType
{
    public int CameraTypeId { get; set; }

    public string CameraType { get; set; } = null!;

    public virtual ICollection<Rfidcamera> Rfidcameras { get; set; } = new List<Rfidcamera>();
}
