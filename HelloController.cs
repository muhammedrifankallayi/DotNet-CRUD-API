using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]


public class HellosController : ControllerBase
{
    [HttpGet("data")]
    public IActionResult Get()
    {
        return Ok(new { Message = "Hello, APIkkk!" });
    }
}


