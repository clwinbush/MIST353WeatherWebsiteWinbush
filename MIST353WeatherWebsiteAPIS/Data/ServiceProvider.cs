using System;
using System.Collections.Generic;

namespace MIST353WeatherWebsiteAPIS.Data;

public partial class ServiceProvider
{
    public int ProviderId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? ContactPerson { get; set; }

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? Website { get; set; }

    public int? LocationId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Location? Location { get; set; }
}
