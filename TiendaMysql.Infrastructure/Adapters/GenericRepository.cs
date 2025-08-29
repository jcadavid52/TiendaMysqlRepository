using TiendaMysql.Domain.Ports;
using TiendaMysql.Infrastructure.DataSource;

namespace TiendaMysql.Infrastructure.Adapters
{
    public class GenericRepository<T>(DataContext context) : IGenericRepository<T> where T : class
    {
        public IQueryable<T> Query() => context.Set<T>();

        public async Task CreateAsync(T entity) => await context.Set<T>().AddAsync(entity);
    }
}
