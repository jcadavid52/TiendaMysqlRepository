using Microsoft.EntityFrameworkCore;
using System.Data;
using TiendaMysql.Application.Exceptions;
using TiendaMysql.Domain.Ports;
using TiendaMysql.Infrastructure.DataSource;

namespace TiendaMysql.Infrastructure.Adapters
{
    public class UnitOfWork (DataContext dataContext) : IUnitOfWork
    {
        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await dataContext.SaveChangesAsync(cancellationToken);

                return result;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new ConcurrencyException("La excepcion por concurrencia se disparo", ex);
            }
        }
    }
}
