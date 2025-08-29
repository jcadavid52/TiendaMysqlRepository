using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaMysql.Application.UsesCase.GetAll;

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
    }
}
