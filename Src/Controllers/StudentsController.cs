using Microsoft.AspNetCore.Mvc;

namespace Ifpoc.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentsController : ControllerBase
{
    [HttpGet("")]
    public IActionResult Get()
    {
        return Ok("All students lalala...");
    }
}
