using System;
using TiendaMysql.Application.Dtos;
namespace TiendaMysql.Application.UsesCase.Producto.GetAll
{
    public record GetAllQueryResponse(List<ProductDto> Products);
}
