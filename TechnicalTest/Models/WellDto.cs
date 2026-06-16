using System.Text.Json.Serialization;

namespace TechnicalTest.Models;

public class WellDto
{
    public int id { get; set; }
    public int platformId { get; set; }
    public string uniqueName { get; set; } = "";
    public double latitude { get; set; }
    public double longitude { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    
    [JsonIgnore]
    public PlatformDto Platform { get; set; } = null!;
}
// public class WellDto
// {
//     public int id { get; set; }
//     public int platformId { get; set; }
//     public string uniqueName { get; set; } = "";
//     public double latitude { get; set; }
//     public double longitude { get; set; }
//     public DateTime createdAt { get; set; }
//     public DateTime updatedAt { get; set; }

//     public PlatformDto Platform { get; set; } = null!;
// }
