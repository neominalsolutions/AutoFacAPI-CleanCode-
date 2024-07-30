using MediatR;

namespace AutoFacAPI.Features.Product.Dtos
{
  public record UpdateProductDto(string Name, decimal Price, int Stock = 10);

}
