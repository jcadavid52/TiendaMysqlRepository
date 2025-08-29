using MediatR;
using TiendaMysql.Application.Dtos;
using TiendaMysql.Domain.Ports;

namespace TiendaMysql.Application.UsesCase.Producto.GetAll
{
    public class GetAllQueryHandler(IProductRepository productRepository) : IRequestHandler<GetAllQuery, GetAllQueryResponse>
    {
        public async Task<GetAllQueryResponse> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
           var products =  await productRepository.GetAll();

           var productsDto = products.Select(d => new ProductDto(d.Name,d.Price));

           return new GetAllQueryResponse(productsDto.ToList());
        }
    }
}
