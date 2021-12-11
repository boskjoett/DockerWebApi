using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DockerWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ApiController : ControllerBase
{
    private readonly ILogger<ApiController> _logger;

    public ApiController(ILogger<ApiController> logger)
    {
        _logger = logger;
    }

    // GET api/time
    [HttpGet("time")]
    public ActionResult<DateTime> GetCurrentTime()
    {
        return Ok(DateTime.Now);
    }

    // GET api/hostname
    [HttpGet("hostname")]
    public ActionResult<string> GetHostname()
    {
        return Ok(Dns.GetHostName());
    }

    // GET api/square/5
    [HttpGet("square/{n}")]
    public ActionResult<int> GetSquare(int n)
    {
        _logger.LogInformation($"Returning the square of {n}");
        return n * n;
    }
}
