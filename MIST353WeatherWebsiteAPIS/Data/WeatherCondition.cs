using System;
using System.Collections.Generic;

namespace MIST353WeatherWebsiteAPIS.Data;

public partial class WeatherCondition
{
    public int WeatherConditionId { get; set; }

    public int LocationId { get; set; }

    public int ClimateId { get; set; }

    public decimal? AverageTemperature { get; set; }

    public decimal? AverageRainfall { get; set; }

    public decimal? HumidityLevel { get; set; }

    public DateTime? LastUpdated { get; set; }

    public virtual Climate Climate { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;
}
