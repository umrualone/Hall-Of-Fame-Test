using HallOfFame.Application.Interfaces.Services;
using HallOfFame.Application.Services;
using HallOfFame.Domain.Interfaces.Repositories;
using HallOfFame.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace HallOfFame.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddProjectServices(this IServiceCollection services)
        {
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IPersonService, PersonService>();
        }
    }
}
