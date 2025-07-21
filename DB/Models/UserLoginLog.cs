using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class UserLoginLog
{
    public int UserLoginLogId { get; set; }

    public int UserId { get; set; }

    public DateTime LoginDate { get; set; }

    public DateTime LogoutDate { get; set; }

    public string? MachineIp { get; set; }

    public string BrowserName { get; set; } = null!;

    public virtual UserAccount User { get; set; } = null!;
}
