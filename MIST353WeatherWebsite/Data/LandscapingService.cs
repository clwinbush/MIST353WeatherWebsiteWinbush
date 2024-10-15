using System;
using System.Collections.Generic;

namespace MIST353WeatherWebsite.Data;

public partial class LandscapingService
{
    public int ServiceId { get; set; }

    public string ServiceName { get; set; } = null!;

    public string? Description { get; set; }

    public string? Category { get; set; }

    public string? PriceRange { get; set; }

    public virtual ICollection<ServiceSuitability> ServiceSuitabilities { get; set; } = new List<ServiceSuitability>();
}
