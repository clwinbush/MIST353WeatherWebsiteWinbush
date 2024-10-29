using System;
using System.Collections.Generic;

namespace MIST353WeatherWebsiteAPIS.Data;

public partial class Location
{
    public int LocationId { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string? ZipCode { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public virtual ICollection<ServiceProvider> ServiceProviders { get; set; } = new List<ServiceProvider>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<WeatherCondition> WeatherConditions { get; set; } = new List<WeatherCondition>();
}
