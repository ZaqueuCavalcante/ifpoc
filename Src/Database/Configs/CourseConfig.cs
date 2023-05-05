using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IfPoc.Domain;

namespace IfPoc.Database;

public class CourseConfig : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> course)
    {
        course.ToTable("curso", t =>
        {
            t.HasCheckConstraint("course_level_check", "nivel IN (0,1,2)");
        });

        course.HasKey(c => c.Id)
            .HasName("curso_pkey");

        course.Property(c => c.Id)
            .HasColumnType("int8")
            .UseSequence("curso_seq");

        course.Property(c => c.Name)
            .HasColumnName("nome")
            .HasColumnType("varchar(50)");

        course.Property(c => c.Description)
            .HasColumnName("descricao");

        course.Property(c => c.Level)
            .HasColumnType("int4")
            .HasColumnName("nivel");
    }
}
