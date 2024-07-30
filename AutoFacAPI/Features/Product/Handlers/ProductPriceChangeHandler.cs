using AutoFacAPI.Features.Product.Dtos;
using AutoFacAPI.Features.Product.Events;
using AutoFacAPI.Features.Product.Request;
using MediatR;

namespace AutoFacAPI.Features.Product.Handlers
{
  public class ProductPriceChangeHandler : IRequestHandler<PriceChangeProductRequest>
  {
    private readonly IMediator _mediator;

    public ProductPriceChangeHandler(IMediator mediator)
    {
      _mediator = mediator;
    }

    public async Task Handle(PriceChangeProductRequest request, CancellationToken cancellationToken)
    {
      // nesnenin veri tabanından bulunması
      var product = new Architect.BOA.BLL.Product { Id = request.Id, Name = "Ürün-1", Price = 10, Stock = 10 };
      //product.PriceChanged += Product_PriceChanged;
      product.PriceChange(request.newPrice); // Veri tabanından güncelleme kodu ve saire çalışacak:
      
      // Süreci Event Handler'a devrediyoruz.
      var @event = new ProductPriceChanged(product.Id, product.Price);
      await _mediator.Publish(@event); 

      
    }

    //private void Product_PriceChanged(object? sender, Architect.BOA.BLL.ProductPriceChangedArgs e)
    //{
    //  Console.WriteLine($"Ürünün fiyatı değişti : Eski Fiyat :{e.oldPrice}, Yeni Fiyat: {e.newPrice}");
    //}
  }
}
