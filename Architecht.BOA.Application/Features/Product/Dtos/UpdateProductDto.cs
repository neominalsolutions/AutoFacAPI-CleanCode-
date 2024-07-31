using MediatR;

namespace Architecht.BOA.Application
{
  public record UpdateProductDto(string Name, decimal Price, int Stock = 10);

}
