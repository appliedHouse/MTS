using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LocationFin
{
    public int LocationFinId { get; set; }

    public string LocationRefCode { get; set; } = null!;

    public DateTime AddedDate { get; set; }

    public int AddedBy { get; set; }

    public virtual Location LocationFinNavigation { get; set; } = null!;
}
