using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class SystemSetting
{
    public int SystemSettingId { get; set; }

    public string SmsrequestUrl { get; set; } = null!;

    public string Smsuser { get; set; } = null!;

    public string Smspass { get; set; } = null!;

    public string? ProxyUrl { get; set; }

    public string? ProxyUserName { get; set; }

    public string? ProxyUserPassword { get; set; }

    public string WebMailServer { get; set; } = null!;

    public int WebMailPort { get; set; }

    public string ServerEmail { get; set; } = null!;

    public string ServerEmailPassword { get; set; } = null!;

    public bool EnableSms { get; set; }

    public bool EnableEmail { get; set; }

    public bool IsCurrent { get; set; }

    public Guid AddTransactionId { get; set; }

    public virtual SystemTransaction AddTransaction { get; set; } = null!;
}
