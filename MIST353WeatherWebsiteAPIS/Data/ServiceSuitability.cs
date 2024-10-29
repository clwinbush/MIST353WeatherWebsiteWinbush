using System;
using System.Collections.Generic;

namespace MIST353WeatherWebsiteAPIS.Data;

public partial class ServiceSuitability
{
    public int ServiceSuitabilityId { get; set; }

    public int ServiceId { get; set; }

    public int ClimateId { get; set; }

    public string? SuitabilityDescription { get; set; }

    public virtual Climate Climate { get; set; } = null!;

    public virtual LandscapingService Service { get; set; } = null!;
}
