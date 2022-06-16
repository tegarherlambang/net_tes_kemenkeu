using Microsoft.EntityFrameworkCore;

namespace tescrudmvc.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext()
        {
        }
        public StudentDbContext(DbContextOptions<StudentDbContext> options): base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
