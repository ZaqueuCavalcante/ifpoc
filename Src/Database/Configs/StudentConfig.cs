using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IfPoc.Domain;

namespace IfPoc.Database;

public class StudentConfig : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> student)
    {
        student.ToTable("aluno");

        student.HasKey(s => s.Id)
            .HasName("aluno_pkey");

        student.Property(s => s.Id)
            .HasColumnType("int8")
            .UseSequence("aluno_seq");

        student.Property(s => s.Cpf)
            .HasColumnType("varchar(14)");

        student.Property(s => s.Name)
            .HasColumnName("nome")
            .HasColumnType("varchar(80)");

        student.Property(s => s.Email)
            .HasColumnType("varchar(200)");

        student.Property(s => s.BirthDate)
            .HasColumnName("datanascimento")
            .HasColumnType("timestamp");
    }
}
