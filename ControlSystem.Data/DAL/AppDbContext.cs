using ControlSystem.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlSystem.Data.DAL
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
