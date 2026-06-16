namespace TechnicalTest.Models;

using System.Text.Json.Serialization;

public class PlatformWellResultDto
{
    [JsonPropertyName("PlatformName")]
    public string PlatformName { get; set; } = "";

    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("PlatformId")]
    public int PlatformId { get; set; }

    [JsonPropertyName("UniqueName")]
    public string UniqueName { get; set; } = "";

    [JsonPropertyName("Latitude")]
    public double Latitude { get; set; }

    [JsonPropertyName("Longitude")]
    public double Longitude { get; set; }

    [JsonPropertyName("CreatedAt")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("UpdatedAt")]
    public DateTime UpdatedAt { get; set; }
}