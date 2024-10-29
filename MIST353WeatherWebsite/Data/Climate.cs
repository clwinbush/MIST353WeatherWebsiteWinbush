using System;
using System.Collections.Generic;

namespace MIST353WeatherWebsite.Data;

public partial class Climate
{
    public int ClimateId { get; set; }

    public string ClimateName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Plant> Plants { get; set; } = new List<Plant>();

    public virtual ICollection<ServiceSuitability> ServiceSuitabilities { get; set; } = new List<ServiceSuitability>();

    public virtual ICollection<WeatherCondition> WeatherConditions { get; set; } = new List<WeatherCondition>();
}
