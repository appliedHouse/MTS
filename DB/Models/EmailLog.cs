using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class EmailLog
{
    public int EmailLogId { get; set; }

    public string UserEmail { get; set; } = null!;

    public string Message { get; set; } = null!;

    public DateTime SendDate { get; set; }

    public bool IsSuccess { get; set; }
}
