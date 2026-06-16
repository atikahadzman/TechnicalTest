namespace TechnicalTest.Models;

// One PlatformDto → Many WellDto
public class PlatformDto
{
    public int id { get; set; }
    public string uniqueName { get; set; } = "";
    public double latitude { get; set; }
    public double longitude { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public List<WellDto> Wells { get; set; } = new();
}
