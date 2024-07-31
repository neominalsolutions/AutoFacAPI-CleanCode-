using Architect.BOA.BLL.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architect.BOA.BLL.Services
{
  // Fiyat değişiminde fiyatı takip eden sistemdeki kullanıcılara email atmak istiyoruz.
  // A Profili fiyat %2 oranında düşerse bildir
  // B Profili fiyat 3000 TL ve üstü düşerse bildir.
  public class ProductPriceService:IProductPriceService
  {
    private readonly IProductRepository _productRepository;
    private readonly IMediator _mediator;

    public ProductPriceService(IProductRepository productRepository, IMediator mediator)
    {
      _productRepository = productRepository;
      _mediator = mediator;
    }

    public void UpdatePrice(Guid Id,decimal newPrice)
    {
      var product =  _productRepository.FindById(Id);
      product.PriceChange(newPrice);
      _productRepository.Update(product);

      var @event = new ProductPriceChanged(Id, newPrice);
      _mediator.Publish(@event);

      // event fırlatıp ilgili Id sahip ürünün takip eden kişilere email atılması için bir süreç başlatmam lazım.
    }
  }
}
