using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class Alarm
{
    public Guid AlarmId { get; set; }

    public DateTime OpenDate { get; set; }

    public DateTime? CloseDate { get; set; }

    public int StatusId { get; set; }

    public int? OwnerUserId { get; set; }

    public bool IsSolved { get; set; }

    public int? ClosedByUser { get; set; }

    public int? CloseReasonId { get; set; }

    public int TypeId { get; set; }

    /// <summary>
    /// the entity type of alarm, ex: hardware PAssive Asset or Active Asset
    /// </summary>
    public int CreatorTypeId { get; set; }

    public int LocationId { get; set; }

    public int? ZoneId { get; set; }

    public virtual AlarmActiveAsset? AlarmActiveAsset { get; set; }

    public virtual AlarmHardware? AlarmHardware { get; set; }

    public virtual AlarmPassiveAsset? AlarmPassiveAsset { get; set; }

    public virtual LtalarmCloseReason? CloseReason { get; set; }

    public virtual UserAccount? ClosedByUserNavigation { get; set; }

    public virtual LtcreatorType CreatorType { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual UserAccount? OwnerUser { get; set; }

    public virtual ICollection<Smslog> Smslogs { get; set; } = new List<Smslog>();

    public virtual LtalarmStatus Status { get; set; } = null!;

    public virtual LtalarmType Type { get; set; } = null!;

    public virtual Zone? Zone { get; set; }
}
