using Microsoft.Extensions.DependencyInjection;
using ProgramApplication.Application.Common.Interfaces.Persistence;
using ProgramApplication.Infrastructure.Persistence;

namespace ProgramApplication.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProgramRepository, ProgramRespository>();
            services.AddScoped<IApplicationFormRepository, ApplicationFormRepository>();
            return services;
        }
    }
}
