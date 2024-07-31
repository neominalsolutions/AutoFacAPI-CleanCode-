using MediatR;

namespace Architect.BOA.BLL
{
  // INotification ile program tarafında bir event sınıfı tanımladık
  public record ProductPriceChanged(Guid Id,decimal price):INotification;
  
}
