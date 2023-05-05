namespace IfPoc.Domain;

public class Course
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public CourseLevel Level { get; set; }

    public List<Student> Students { get; set; }

    public void ChangeLevel(CourseLevel newLevel)
    {
        Level = newLevel;
    }
}
