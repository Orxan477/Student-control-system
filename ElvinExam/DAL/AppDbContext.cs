using ElvinExam.Models;
using Microsoft.EntityFrameworkCore;

namespace ElvinExam.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        public DbSet<Months> Months { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Paids> Paids { get; set; }
        public DbSet<Setting>Settings { get; set; }
    }
}
