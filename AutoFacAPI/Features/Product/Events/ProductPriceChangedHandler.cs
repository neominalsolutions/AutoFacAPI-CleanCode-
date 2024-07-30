using MediatR;

namespace AutoFacAPI.Features.Product.Events
{
  public class ProductPriceChangedHandler : INotificationHandler<ProductPriceChanged>
  {
    public Task Handle(ProductPriceChanged notification, CancellationToken cancellationToken)
    {
      // idsine göre product bu notification.Id
     

      Console.WriteLine($"Ürünün fiyatı değişti : Güncel Fiyat :{notification.price}, Yeni Fiyat:");

      return Task.CompletedTask;
    }
  }
}
