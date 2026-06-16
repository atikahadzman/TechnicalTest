using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using TechnicalTest.Models;

namespace TechnicalTest.Controllers;

// http://test-demo.aemenersol.com/api/Account/Login

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly ApiSettings _apiSettings;

    public AuthController(IHttpClientFactory httpClientFactory, IOptions<ApiSettings> options)
    {
        _httpClientFactory = httpClientFactory;
        _apiSettings = options.Value;
    }

    /**
     * method : POST
     * api endpoint : /api/Auth/login
     * purpose : this is for login to get token  
    */
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var client = _httpClientFactory.CreateClient();
        var url = $"{_apiSettings.BaseUrl}/Account/Login";
        var json = JsonSerializer.Serialize(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await client.PostAsync(
            url,
            content);

        var raw = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            var error = new ErrorDto
            {
                message = $"Login failed. Status Code: {response.StatusCode}",
                stackTrace = "",
                innerException = raw,
                columnName = "",
                columnValue = "",
            };

            return BadRequest(error);
        }


        return Ok(raw);
    }
}