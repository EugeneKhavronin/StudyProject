using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudyProject.Identity.Domain.Interfaces;
using StudyProject.Identity.Domain.Models;

namespace StudyProject.Identity.API.Controllers
{
    /// <summary>
    /// Контроллер пользователя
    /// </summary>
    [Route("api/User")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserManagementService _userManagementService;

        /// <summary/>
        public UserController(IUserManagementService userManagementService)
        {
            _userManagementService = userManagementService;
        }

        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        /// <param name="model">Модель регистрации</param>
        /// <returns></returns>
        [Route("Register")]
        [HttpPost]
        public async Task<Guid> Registration(RegistrationModel model)
        {
            return await _userManagementService.Registration(model);
        }
    }
}