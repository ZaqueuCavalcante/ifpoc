using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IfPoc.Domain;

namespace IfPoc.Database;

public class StudentCourseConfig : IEntityTypeConfiguration<StudentCourse>
{
    public void Configure(EntityTypeBuilder<StudentCourse> studentCourse)
    {
        studentCourse.ToTable("alunocurso");

        studentCourse.HasKey(sc => sc.Id)
            .HasName("alunocurso_pkey");

        studentCourse.Property(sc => sc.Id)
            .HasColumnType("int8")
            .UseSequence("alunocurso_seq");

        studentCourse.Property(sc => sc.StudentId)
            .HasColumnType("int8")
            .HasColumnName("alunoid");

        studentCourse.Property(sc => sc.CourseId)
            .HasColumnType("int8")
            .HasColumnName("cursoid");

        studentCourse.HasOne<Student>()
            .WithMany()
            .HasForeignKey(sc => sc.StudentId)
            .OnDelete(DeleteBehavior.NoAction);

        studentCourse.HasOne<Course>()
            .WithMany()
            .HasForeignKey(sc => sc.CourseId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
