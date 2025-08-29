using MediatR;

namespace TiendaMysql.Application.UsesCase.Producto.Create
{
    public record CreateCommand(string Name,decimal Price):IRequest<int>;
}
