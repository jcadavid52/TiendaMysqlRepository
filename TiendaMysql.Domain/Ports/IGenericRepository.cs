namespace TiendaMysql.Domain.Ports
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> Query();
    }
}
