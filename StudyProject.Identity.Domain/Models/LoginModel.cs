using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StudyProject.Identity.Domain.Models
{
    /// <summary>
    /// Модель автроизации
    /// </summary>
    public class LoginModel
    {
        /// <summary>
        /// Логин пользователя
        /// </summary>
        [Required]
        [JsonProperty("login")]
        public string Login { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        [Required]
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}