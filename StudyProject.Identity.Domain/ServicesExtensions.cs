using Microsoft.Extensions.DependencyInjection;
using StudyProject.Identity.Domain.Interfaces;
using StudyProject.Identity.Domain.Services;

namespace StudyProject.Identity.Domain
{
    public static class ServicesExtensions
    {
        /// <summary>
        /// Добавление сервисов
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}