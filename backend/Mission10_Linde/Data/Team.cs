using System;
using System.Collections.Generic;

namespace Mission10_Linde.Data;

public partial class Team
{
    public int TeamId { get; set; }

    public string TeamName { get; set; } = null!;

    public int? CaptainId { get; set; }

    public ICollection<Bowler> Bowlers { get; set; }
}
