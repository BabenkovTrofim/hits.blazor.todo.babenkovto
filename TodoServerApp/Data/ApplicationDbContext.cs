using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<TaskItem> TaskItems { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var seedDate = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            builder.Entity<TaskItem>().HasData(
                new TaskItem { Id = 1, Title = "Задача 1", Description = "Описание задачи 1", CreatedDate = seedDate },
                new TaskItem { Id = 2, Title = "Задача 2", Description = "Описание задачи 2", CreatedDate = seedDate },
                new TaskItem { Id = 3, Title = "Задача 3", Description = "Описание задачи 3", CreatedDate = seedDate },
                new TaskItem { Id = 4, Title = "Задача 4", Description = "Описание задачи 4", CreatedDate = seedDate }
            );
        }
    }
}
