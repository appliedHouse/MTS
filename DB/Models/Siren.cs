using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Siren
{
    public int SirenId { get; set; }

    public string SirenTitle { get; set; } = null!;

    public int? HardwareId { get; set; }

    public int LocationId { get; set; }

    public int? RelayPortId { get; set; }

    public int? RelatedHardwareId { get; set; }

    public string? HardwarePort { get; set; }

    public bool IsRelatedToHardware { get; set; }

    public DateTime? LastAlarmTime { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual SirenRelay? Hardware { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual Hardware? RelatedHardware { get; set; }

    public virtual LtrelayPort? RelayPort { get; set; }

    public virtual ICollection<SirenLocation> SirenLocations { get; set; } = new List<SirenLocation>();

    public virtual ICollection<SirenReader> SirenReaders { get; set; } = new List<SirenReader>();

    public virtual ICollection<SirenRole> SirenRoles { get; set; } = new List<SirenRole>();

    public virtual SystemTransaction? UpdateTransaction { get; set; }
}
