using Microsoft.EntityFrameworkCore;

namespace IfPoc.Database;

public class IfPocDbContext : DbContext
{
    // public DbSet<Label> Labels { get; set; }

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
