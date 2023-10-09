using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.DependencyInjection;
using ProgramApplication.Application.Common.Interfaces.Persistence;
using ProgramApplication.Infrastructure.Persistence;

namespace ProgramApplication.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDependencies
            (this IServiceCollection services)
        {
            services.AddRepositoryDependencies();
            services.AddCosmosDependencies();
            return services;
        }
        
        public static IServiceCollection AddCosmosDependencies
            (this IServiceCollection services)
        {
            services.AddSingleton(() =>
            {
                var cosmosClientOptions = new CosmosClientOptions
                {
                    ApplicationName = CosmosConfig.DatabaseName
                };
                var cosmosClient = new CosmosClient(CosmosConfig.ConnectionString, cosmosClientOptions);
                cosmosClient.ClientOptions.ConnectionMode = ConnectionMode.Direct;
                return cosmosClient;
            });
            return services;
        }
        
        public static IServiceCollection AddRepositoryDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProgramRepository, ProgramRespository>();
            services.AddScoped<IApplicationFormRepository, ApplicationFormRepository>();
            services.AddScoped<IWorkflowRepository, WorkflowRepository>();
            return services;
        }
    }
}
