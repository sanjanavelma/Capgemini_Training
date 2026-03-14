using Microsoft.EntityFrameworkCore;
using EFtestStart.Models;

namespace EFtestStart.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}