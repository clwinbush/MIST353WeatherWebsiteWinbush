using System;
using System.Collections.Generic;

namespace MIST353WeatherWebsite.Data;

public partial class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public int? LocationId { get; set; }

    public virtual Location? Location { get; set; }
}
