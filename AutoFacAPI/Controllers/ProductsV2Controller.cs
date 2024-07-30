using AutoFacAPI.Features.Product.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoFacAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductsV2Controller : ControllerBase
  {
    private readonly IMediator _mediator;

    public ProductsV2Controller(IMediator mediator)
    {
      _mediator = mediator;
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProductDto request)
    {
       await _mediator.Send(request);

      return Created("/api/productsV2/1",request); // 201 Post istekleri eğer yeni bir kaynak oluşturuyor statusCode 201 olarak döndürmemiz lazım
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] UpdateProductDto request)
    {
      await _mediator.Send(request);

      return NoContent(); // 204 
    }


  }
}
