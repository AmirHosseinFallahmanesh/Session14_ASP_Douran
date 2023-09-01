using Microsoft.EntityFrameworkCore;

namespace Demo.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options):base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
    }
}
