using BaseProject.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace BestPractices101.Entity
{
    public class AppDbContext : BaseProjectDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
