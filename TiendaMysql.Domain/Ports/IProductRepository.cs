using TiendaMysql.Domain.Models;

namespace TiendaMysql.Domain.Ports
{
    public interface IProductRepository: IGenericRepository<Product>
    {
        Task<List<Product>> GetAll();
    }
}
