using Microsoft.EntityFrameworkCore;
using IfPoc.Domain;

namespace IfPoc.Database;

public class IfPocDbContext : DbContext
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }

    public IfPocDbContext(DbContextOptions<IfPocDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.HasDefaultSchema("public");

        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}
