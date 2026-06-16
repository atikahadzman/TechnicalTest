namespace TechnicalTest.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

public class WellDummyDto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int id { get; set; }
    public int platformId { get; set; }
    public string uniqueName { get; set; } = "";
    public double latitude { get; set; }
    public double longitude { get; set; }
    public DateTime lastUpdate { get; set; }

    [JsonIgnore]
    public PlatformDummyDto? Platform { get; set; }
} 
