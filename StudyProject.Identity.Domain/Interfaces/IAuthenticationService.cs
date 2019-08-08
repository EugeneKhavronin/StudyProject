using StudyProject.Identity.Domain.Models;

namespace StudyProject.Identity.Domain.Interfaces
{
    /// <summary>
    /// Сервис аутентификации и выдачи токена
    /// </summary>
    public interface IAuthenticationService
    {
        /// <summary>
        /// Аутентификация и выдача токена
        /// </summary>
        /// <param name="model">Модель авторизации</param>
        /// <returns></returns>
        string Authenticate(LoginModel model);
    }
}