using CourseRegistrationApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseRegistrationApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CoursesController
{
    [HttpGet]
    public IEnumerable<Course> Get()
    {
        return
        [
            new Course {Id = 0, Subject = "ENGL", CourseNumber = "101"},
            new Course {Id = 1, Subject = "HIST", CourseNumber = "201"},
            new Course {Id = 3, Subject = "MEDI", CourseNumber = "352"}
        ];
    }
}