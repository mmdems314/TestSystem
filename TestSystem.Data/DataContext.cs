using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestSystem.Data.Entites;

namespace TestSystem.Data
{
    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Answer> Answers { get; set; }

        public DbSet<Exam> Exams { get; set; }

        public DbSet<ExamResult> ExamResults { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            Database.Migrate();
        }
    }
}
