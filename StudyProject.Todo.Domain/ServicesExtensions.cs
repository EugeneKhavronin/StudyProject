using Microsoft.Extensions.DependencyInjection;
using StudyProject.Todo.Domain.Interfaces;
using StudyProject.Todo.Domain.Services;

namespace StudyProject.Todo.Domain
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
            services.AddScoped<ITodoService, TodoService>();
            
            return services;
        }
    }
}