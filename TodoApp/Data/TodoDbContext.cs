using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data;

public class TodoDbContext : DbContext
{
    public TodoDbContext(DbContextOptions<TodoDbContext> options)
        : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // 種子資料 (Seed data)
        modelBuilder.Entity<TodoItem>().HasData(
            new TodoItem
            {
                Id = 1,
                Title = "學習 .NET 9",
                Description = "學習 .NET 9 的新功能",
                IsCompleted = false,
                CreatedAt = DateTime.Now
            },
            new TodoItem
            {
                Id = 2,
                Title = "建立 MVC 專案",
                Description = "使用 ASP.NET Core MVC 建立專案",
                IsCompleted = true,
                CreatedAt = DateTime.Now.AddDays(-1),
                CompletedAt = DateTime.Now
            },
            new TodoItem
            {
                Id = 3,
                Title = "實作 TODO 功能",
                Description = "實作 CRUD 操作",
                IsCompleted = false,
                CreatedAt = DateTime.Now
            }
        );
    }
}
