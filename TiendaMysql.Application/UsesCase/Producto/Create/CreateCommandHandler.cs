using MediatR;
using TiendaMysql.Domain.Models;
using TiendaMysql.Domain.Ports;

namespace TiendaMysql.Application.UsesCase.Producto.Create
{
    public class CreateCommandHandler (
        IProductRepository productRepository,
        IUnitOfWork unitOfWork
        ) : IRequestHandler<CreateCommand, int>
    {
        public async Task<int> Handle(CreateCommand request, CancellationToken cancellationToken)
        {
            var product = Product.Create(request.Name, request.Price);

            await productRepository.CreateAsync(product);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            return product.Id;
        }
    }
}
