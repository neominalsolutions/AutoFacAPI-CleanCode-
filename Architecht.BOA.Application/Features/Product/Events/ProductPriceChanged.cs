using MediatR;

namespace Architecht.BOA.Application
{
  // INotification ile program tarafında bir event sınıfı tanımladık
  public record ProductPriceChanged(int Id,decimal price):INotification;
  
}
