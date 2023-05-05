using Microsoft.AspNetCore.Mvc;

namespace Ifpoc.Controllers;

[ApiController]
[Route("[controller]")]
public class CoursesController : ControllerBase
{
    [HttpGet("")]
    public IActionResult Get()
    {
        return Ok("All courses lalala...");
    }
}
