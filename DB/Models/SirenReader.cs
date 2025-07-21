using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class SirenReader
{
    public int SirenReaderId { get; set; }

    public int SirenId { get; set; }

    public int ReaderId { get; set; }

    public virtual Hardware Reader { get; set; } = null!;

    public virtual Siren Siren { get; set; } = null!;
}
