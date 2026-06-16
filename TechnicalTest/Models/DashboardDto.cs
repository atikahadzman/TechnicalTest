namespace TechnicalTest.Models;

public class DashboardDto
{
    public bool success { get; set; }
    public List<ChartDashboardDto> chartDonut { get; set; } = new();
    public List<ChartDashboardDto> chartBar { get; set; } = new();
    public List<TableUserDto> tableUsers { get; set; } = new();
}