using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyTask.Core.Models.Domains;
using MyTask.Core.ViewModels;

namespace MyTask.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MyTasks> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}