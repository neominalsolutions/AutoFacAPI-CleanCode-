using MediatR;

namespace Architecht.BOA.Application
{
  public record PriceChangeProductRequest(int Id,decimal newPrice):IRequest;
  
}
