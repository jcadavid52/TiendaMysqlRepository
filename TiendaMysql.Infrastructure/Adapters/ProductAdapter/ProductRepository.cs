using Microsoft.EntityFrameworkCore;
using TiendaMysql.Domain.Models;
using TiendaMysql.Domain.Ports;
using TiendaMysql.Infrastructure.DataSource;

namespace TiendaMysql.Infrastructure.Adapters.ProductAdapter
{
    [Repository]
    public class ProductRepository(DataContext context) : GenericRepository<Product>(context),IProductRepository
    {
        public async Task<List<Product>> GetAll() => await Query().ToListAsync();
    }
}
