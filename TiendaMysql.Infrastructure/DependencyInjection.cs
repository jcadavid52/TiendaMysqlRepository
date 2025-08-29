using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TiendaMysql.Infrastructure.Adapters;
using TiendaMysql.Infrastructure.DataSource;

namespace TiendaMysql.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("db")
             ?? throw new ArgumentNullException(nameof(configuration));

            services.AddDbContext<DataContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            var _repositories = AppDomain.CurrentDomain.GetAssemblies()
           .Where(assembly =>
           {
               return assembly.FullName is null || assembly.FullName.Contains("Infrastructure", StringComparison.OrdinalIgnoreCase);
           })
           .SelectMany(assembly => assembly.GetTypes())
           .Where(type => type.CustomAttributes.Any(attribute => attribute.AttributeType == typeof(RepositoryAttribute)));

            foreach (var repository in _repositories)
            {
                foreach (var typeInterface in repository.GetInterfaces())
                {
                    services.AddTransient(typeInterface, repository);
                }
            }

            return services;
        }
    }
}
