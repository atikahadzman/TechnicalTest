namespace TechnicalTest.Models;

public class ErrorDto
{
    public string message { get; set; } = "";
    public string? stackTrace { get; set; } = "";
    public string? innerException { get; set; } = "";
    public string columnName { get; set; } = "";
    public string columnValue { get; set; } = "";
} 
