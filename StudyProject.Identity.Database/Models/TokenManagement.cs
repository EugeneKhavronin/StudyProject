using Newtonsoft.Json;

namespace StudyProject.Identity.Database.Models
{
    /// <summary>
    /// Класс токена
    /// </summary>
    [JsonObject("tokenManagement")]
    public class TokenManagement
    {
        /// <summary>
        /// Ключ для шифрации
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// Издатель токена
        /// </summary>
        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// Потребитель токена
        /// </summary>
        [JsonProperty("audience")]
        public string Audience { get; set; }

        /// <summary>
        /// время когда токен станет не валидным
        /// </summary>
        [JsonProperty("accessExpiration")]
        public int AccessExpiration { get; set; }
    }
}