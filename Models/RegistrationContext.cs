using Microsoft.EntityFrameworkCore;

namespace CourseRegistrationApi.Models;

public class RegistrationContext : DbContext
{
    public RegistrationContext(DbContextOptions<RegistrationContext> options)
        : base(options)
    {
    }

    public DbSet<Course> Courses { get; set; } = null!;
}