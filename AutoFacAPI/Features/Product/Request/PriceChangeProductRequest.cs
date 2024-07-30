using MediatR;

namespace AutoFacAPI.Features.Product.Request
{
  public record PriceChangeProductRequest(int Id,decimal newPrice):IRequest;
  
}
