using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudyProject.Identity.Database;
using StudyProject.Identity.Database.Models;
using StudyProject.Identity.Domain.Interfaces;
using StudyProject.Identity.Domain.Models;

namespace StudyProject.Identity.Domain.Services
{
    /// <inheritdoc/>
    public class UserService : IUserService
    {
        private readonly DatabaseContext _context;
        private readonly IPasswordHasher<User> _passwordHasher = new PasswordHasher<User>();

        /// <summary/>
        public UserService(DatabaseContext databaseContext)
        {
            _context = databaseContext;
        }

        /// <inheritdoc/>
        public async Task<bool> ValidateUser(string login, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Login == login);
            var result = _passwordHasher.VerifyHashedPassword(user, user.Password, password);

            return result == PasswordVerificationResult.Success;
        }

        /// <inheritdoc/>
        public async Task<Guid> Registration(RegistrationModel model)
        {
            var user = new User
            {
                Guid = Guid.NewGuid(),
                Login = model.Login,
            };
            user.Password = _passwordHasher.HashPassword(user, model.Password);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user.Guid;
        }
    }
}