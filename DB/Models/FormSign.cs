using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class FormSign
{
    public int FormSignId { get; set; }

    public int SignId { get; set; }

    public int ServiceId { get; set; }

    public virtual SystemService Service { get; set; } = null!;

    public virtual EmployeeSign Sign { get; set; } = null!;
}
