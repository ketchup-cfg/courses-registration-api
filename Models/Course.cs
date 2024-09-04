namespace CourseRegistrationApi.Models;

public class Course
{
    public long Id { get; set; }
    public string Subject { get; set; } = string.Empty;
    public string CourseNumber { get; set; } = string.Empty;
}