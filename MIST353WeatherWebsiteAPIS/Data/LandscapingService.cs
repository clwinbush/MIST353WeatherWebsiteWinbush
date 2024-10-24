using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MIST353WeatherWebsiteAPIS.Data;

public partial class LandscapingService
{
    [Key]
    public int ServiceId { get; set; }
   

    public string ServiceName { get; set; } = null!;

    public string? Description { get; set; }

    public string? Category { get; set; }

    public string? PriceRange { get; set; }

    public virtual ICollection<ServiceSuitability> ServiceSuitabilities { get; set; } = new List<ServiceSuitability>();
}
