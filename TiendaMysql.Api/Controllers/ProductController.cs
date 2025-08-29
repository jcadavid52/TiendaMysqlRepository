using MediatR;
using Microsoft.AspNetCore.Mvc;
using TiendaMysql.Application.UsesCase.Producto.Create;
using TiendaMysql.Application.UsesCase.Producto.GetAll;

namespace TiendaMysql.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IMediator mediator) : ControllerBase
    {
        [HttpGet("get-all")]
        public async Task<IActionResult> GetProducts()
        {
           var products =  await mediator.Send(new GetAllQuery());
           return Ok(products);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateCommand command)
        {
           var id =  await mediator.Send(command);

            return Created("",new {id = id});
        }
    }
}
