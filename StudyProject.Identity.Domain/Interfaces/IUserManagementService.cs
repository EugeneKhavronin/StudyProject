using System;
using System.Threading.Tasks;
using StudyProject.Identity.Domain.Models;

namespace StudyProject.Identity.Domain.Interfaces
{
    /// <summary>
    /// Сервис по работе с пользователями
    /// </summary>
    public interface IUserManagementService
    {
        /// <summary>
        /// Проверка существует ли пользователь
        /// </summary>
        /// <param name="login">Логин пользователя</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        Task<bool> ValidUser(string login, string password);

        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        /// <param name="model">Модель регистрации</param>
        /// <returns></returns>
        Task<Guid> Registration(RegistrationModel model);
    }
}