using NUnit.Framework;
using FluentAssertions;
using IfPoc.Domain;

namespace Tests;

public class UnitTests
{
    [Test]
    public void Should_update_the_course_level_from_easy_to_hard()
    {
        // Arrange
        var course = new Course();
        const CourseLevel newLevel = CourseLevel.Hard;

        // Act
        course.ChangeLevel(newLevel);

        // Assert
        course.Level.Should().Be(newLevel);
    }
}
