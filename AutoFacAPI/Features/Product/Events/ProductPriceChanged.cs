using MediatR;

namespace AutoFacAPI.Features.Product.Events
{
  // INotification ile program tarafında bir event sınıfı tanımladık
  public record ProductPriceChanged(int Id,decimal price):INotification;
  
}
