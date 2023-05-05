namespace IfPoc.Domain;

public class Student
{
    public long Id { get; set; }

    public string? Cpf { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public DateTime? BirthDate { get; set; }

    public List<Course> Courses { get; set; }
}
