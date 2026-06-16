namespace TechnicalTest.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// One PlatformDummyDto → Many WellDummyDto
public class PlatformDummyDto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int id { get; set; }
    public string uniqueName { get; set; } = "";
    public double latitude { get; set; }
    public double longitude { get; set; }
    public DateTime lastUpdate { get; set; }

    public List<WellDummyDto> Wells { get; set; } = new();
}