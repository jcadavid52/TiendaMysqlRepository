using Microsoft.EntityFrameworkCore;
using TiendaMysql.Domain.Models;

namespace TiendaMysql.Infrastructure.DataSource
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }
    }
}
