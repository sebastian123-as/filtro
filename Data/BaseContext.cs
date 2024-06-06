using Filtro.Models;
using Microsoft.EntityFrameworkCore;

namespace Filtro.Data;

public class BaseContext : DbContext{
    public BaseContext(DbContextOptions<BaseContext> options) : base(options) {}

    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Student> Students { get ; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
}