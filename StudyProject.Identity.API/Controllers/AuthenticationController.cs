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
        private readonly IAuthenticationService _authenticateService;

        /// <summary/>
        public AuthenticationController(IAuthenticationService authService)
        {
            _authenticateService = authService;
        }

        /// <summary>
        /// Аутентификация и выдача токена
        /// </summary>
        /// <param name="model">Модель авторизации</param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost, Route("Authentication")]
        public IActionResult Authentication(LoginModel model)
        {
            var token = _authenticateService.Authentication(model);
            return Ok(token);
        }
    }
}