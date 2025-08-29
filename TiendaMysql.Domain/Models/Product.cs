using TiendaMysql.Domain.Common;

namespace TiendaMysql.Domain.Models
{
    public class Product:DomainEntity
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public static Product Create(string name, decimal price)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);

            return new Product
            {
                Name = name,
                Price = price
            };
        }
    }
}
