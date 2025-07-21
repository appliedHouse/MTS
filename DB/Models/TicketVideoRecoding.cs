using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class TicketVideoRecoding
{
    public int TicketVideoRecordingId { get; set; }

    public string VideoFilePath { get; set; } = null!;

    public int TicketId { get; set; }

    public int RecordCameraId { get; set; }
}
