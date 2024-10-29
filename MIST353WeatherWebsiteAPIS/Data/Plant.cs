using System;
using System.Collections.Generic;

namespace MIST353WeatherWebsiteAPIS.Data;

public partial class Plant
{
    public int PlantId { get; set; }

    public string PlantName { get; set; } = null!;

    public string? ScientificName { get; set; }

    public string? Description { get; set; }

    public int? ClimateId { get; set; }

    public virtual Climate? Climate { get; set; }
}
