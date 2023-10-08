using ProgramApplication.Api.Common.Mapping;

namespace ProgramApplication.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentationDependencies(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddMappingDependencies();
            
            return services;
        }
    }
}
