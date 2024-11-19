using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MIST353WeatherWebsite.Data;

public partial class Plant
{
    [JsonPropertyName("plantId")] //Needed to add in order for the deserializer to work, links the JSON name to the attribute name
    public int PlantId { get; set; }

    [JsonPropertyName("plantName")]
    public string PlantName { get; set; } = null!;

    [JsonPropertyName("scientificName")]
    public string? ScientificName { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("climateId")]
    public int? ClimateId { get; set; }

    [JsonPropertyName("climate")]
    public virtual Climate? Climate { get; set; }
}
