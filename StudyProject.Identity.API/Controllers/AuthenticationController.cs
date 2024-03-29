using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudyProject.Identity.Domain.Interfaces;
using StudyProject.Identity.Domain.Models;

namespace StudyProject.Identity.API.Controllers
{
    /// <summary>
    /// Контроллер аутентификации и выдачи токена
    /// </summary>
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authenticationService;

        /// <summary/>
        public AuthenticationController(IAuthenticationService authService)
        {
            _authenticationService = authService;
        }

        /// <summary>
        /// Аутентификация и выдача токена
        /// </summary>
        /// <param name="model">Модель авторизации</param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost, Route("Authentication")]
        public IActionResult Authenticate([FromBody] LoginModel model)
        {
            var token = _authenticationService.Authenticate(model);
            return Ok(token);
        }
    }
}