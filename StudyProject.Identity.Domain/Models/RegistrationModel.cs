using System.ComponentModel.DataAnnotations;

namespace StudyProject.Identity.Domain.Models
{
    /// <summary>
    /// Модель регистрации
    /// </summary>
    public class RegistrationModel
    {
        /// <summary>
        /// Логин
        /// </summary>
        [Required]
        public string Login { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}