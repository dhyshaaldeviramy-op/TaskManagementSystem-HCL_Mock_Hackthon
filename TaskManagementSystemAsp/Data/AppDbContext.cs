using Microsoft.EntityFrameworkCore;
using TaskManagementSystemAsp.Models;

namespace TaskManagementSystemAsp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}
