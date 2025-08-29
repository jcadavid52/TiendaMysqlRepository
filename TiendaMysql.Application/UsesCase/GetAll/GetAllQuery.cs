using MediatR;

namespace TiendaMysql.Application.UsesCase.GetAll
{
    public record GetAllQuery():IRequest<GetAllQueryResponse>;
}
