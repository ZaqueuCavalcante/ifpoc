using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IfPoc.Domain;
using IfPoc.Database;

namespace Ifpoc.Controllers;

[ApiController]
[Route("[controller]")]
public class CoursesController : ControllerBase
{
    private readonly IfPocDbContext _context;

    public CoursesController(IfPocDbContext context)
    {
        _context = context;
    }

    [HttpPost("")]
    public async Task<IActionResult> Create([FromBody] Course data)
    {
        _context.Courses.Add(data);
        await _context.SaveChangesAsync();

        return Ok(data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Read([FromRoute] long id)
    {
        var course = await _context.Courses.FirstOrDefaultAsync(c => c.Id == id);

        if (course is null)
        {
            return NotFound();
        }

        return Ok(course);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] long id, [FromBody] Course data)
    {
        var oldData = await _context.Courses.FirstOrDefaultAsync(c => c.Id == id);

        if (oldData is null)
        {
            return NotFound();
        }

        oldData.Name = data.Name;
        oldData.Description = data.Description;
        oldData.Level = data.Level;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] long id)
    {
        var course = await _context.Courses.FirstOrDefaultAsync(c => c.Id == id);

        if (course is null)
        {
            return NotFound();
        }

        _context.Courses.Remove(course);
        await _context.SaveChangesAsync();

        return Ok(course);
    }
}
