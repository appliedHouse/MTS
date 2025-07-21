using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class RfidactiveReader
{
    public int HardwareId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int Attenuation { get; set; }

    public int ReceiveTimeout { get; set; }

    public int SendTimeout { get; set; }

    public int NoOfTriesToConnectB4disabling { get; set; }

    public int TimeB4tryToConnect { get; set; }

    public int ChannelAthreshold { get; set; }

    public int ChannelBthreshold { get; set; }

    public int ReaderTypeId { get; set; }

    public virtual ICollection<AlarmActiveAsset> AlarmActiveAssets { get; set; } = new List<AlarmActiveAsset>();

    public virtual Hardware Hardware { get; set; } = null!;

    public virtual LtreaderFunction ReaderType { get; set; } = null!;
}
