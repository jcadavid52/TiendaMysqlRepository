using System;
using TiendaMysql.Application.Dtos;
namespace TiendaMysql.Application.UsesCase.GetAll
{
    public record GetAllQueryResponse(List<ProductDto> Products);
}
