using MediatR;

namespace Architecht.BOA.Application
{
  public record PriceChangeProductRequest(Guid Id,decimal newPrice):IRequest;
  
}
