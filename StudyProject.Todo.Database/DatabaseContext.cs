using System;
using Microsoft.EntityFrameworkCore;
using StudyProject.Todo.Database.Models;

namespace StudyProject.Todo.Database
{
    public class DatabaseContext : DbContext
    {
        /// <summary />
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        /// <summary>
        /// Заполнение базы задачами
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem {Guid = Guid.NewGuid(), Name = "name1", IsComplete = true},
                new TodoItem {Guid = Guid.NewGuid(), Name = "name2", IsComplete = false},
                new TodoItem {Guid = Guid.NewGuid(), Name = "name3", IsComplete = true}
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}