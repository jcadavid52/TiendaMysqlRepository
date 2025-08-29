using MediatR;

namespace TiendaMysql.Application.UsesCase.Producto.GetAll
{
    public record GetAllQuery():IRequest<GetAllQueryResponse>;
}
