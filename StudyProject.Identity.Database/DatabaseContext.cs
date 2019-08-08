using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudyProject.Identity.Database.Models;

namespace StudyProject.Identity.Database
{
    public class DatabaseContext : DbContext
    {
        private readonly IPasswordHasher<User> _passwordHasher = new PasswordHasher<User>();

        public DatabaseContext(DbContextOptions<DatabaseContext> options) :
            base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Заполнение базы пользователями
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var user = new User
            {
                Guid = Guid.NewGuid(), Login = "admin@gmail.com", Password = "12345"
            };
            user.Password = _passwordHasher.HashPassword(user, user.Password);

            var user2 = new User
            {
                Guid = Guid.NewGuid(), Login = "qwerty", Password = "55555"
            };
            user2.Password = _passwordHasher.HashPassword(user2, user2.Password);

            modelBuilder.Entity<User>().HasData(
                user,
                user2
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}