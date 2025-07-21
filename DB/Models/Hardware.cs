using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Hardware
{
    public int HardwareId { get; set; }

    public string HardwareIp { get; set; } = null!;

    public int? HardwarePort { get; set; }

    public int HardwareType { get; set; }

    public string HardwareName { get; set; } = null!;

    public string HardwareDesc { get; set; } = null!;

    public bool IsConnected { get; set; }

    public bool IsActive { get; set; }

    public bool IsFailToRecover { get; set; }

    public int LocationId { get; set; }

    public int? ZoneId { get; set; }

    public int? SwitchId { get; set; }

    public string? SwitchPort { get; set; }

    public string? HardwareMacadress { get; set; }

    public bool HardwarePowrStatus { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual ICollection<AlarmActiveAsset> AlarmActiveAssets { get; set; } = new List<AlarmActiveAsset>();

    public virtual ICollection<AlarmHardware> AlarmHardwares { get; set; } = new List<AlarmHardware>();

    public virtual ICollection<AlarmPassiveAsset> AlarmPassiveAssets { get; set; } = new List<AlarmPassiveAsset>();

    public virtual LthardwareType HardwareTypeNavigation { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual RfidactiveReader? RfidactiveReader { get; set; }

    public virtual Rfidcamera? Rfidcamera { get; set; }

    public virtual RfidpassiveReader? RfidpassiveReader { get; set; }

    public virtual Rfidscreen? Rfidscreen { get; set; }

    public virtual ICollection<SirenReader> SirenReaders { get; set; } = new List<SirenReader>();

    public virtual SirenRelay? SirenRelay { get; set; }

    public virtual ICollection<Siren> Sirens { get; set; } = new List<Siren>();

    public virtual Switch? Switch { get; set; }

    public virtual SystemTransaction? UpdateTransaction { get; set; }

    public virtual Zone? Zone { get; set; }
}
