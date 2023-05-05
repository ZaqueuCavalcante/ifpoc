using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IfPoc.Domain;
using IfPoc.Database;

namespace Ifpoc.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentsController : ControllerBase
{
    private readonly IfPocDbContext _context;

    public StudentsController(IfPocDbContext context)
    {
        _context = context;
    }

    [HttpPost("")]
    public async Task<IActionResult> Create([FromBody] Student data)
    {
        _context.Students.Add(data);
        await _context.SaveChangesAsync();

        return Ok(data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Read([FromRoute] long id)
    {
        var student = await _context.Students
            .Include(s => s.Courses)
            .FirstOrDefaultAsync(c => c.Id == id);

        if (student is null)
        {
            return NotFound();
        }

        return Ok(student);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] long id, [FromBody] Student data)
    {
        var oldData = await _context.Students.FirstOrDefaultAsync(c => c.Id == id);

        if (oldData is null)
        {
            return NotFound();
        }

        oldData.Cpf = data.Cpf;
        oldData.Name = data.Name;
        oldData.Email = data.Email;
        oldData.BirthDate = data.BirthDate;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] long id)
    {
        var student = await _context.Students.FirstOrDefaultAsync(c => c.Id == id);

        if (student is null)
        {
            return NotFound();
        }

        _context.Students.Remove(student);
        await _context.SaveChangesAsync();

        return Ok(student);
    }
}
