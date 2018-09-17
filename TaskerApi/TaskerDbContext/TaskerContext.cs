using Microsoft.EntityFrameworkCore;
using TaskerApi.Models.Oauth;

namespace TaskerApi.TaskerDbContext
{
    public class TaskerContext : DbContext
    {
        public TaskerContext(DbContextOptions<TaskerContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}