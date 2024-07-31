using Architecht.BOA.Application;
using Architect.BOA.BLL.Services;
using MediatR;

namespace AutoFacAPI.Features.Product.Handlers
{
  public class ProductPriceChangeHandler : IRequestHandler<PriceChangeProductRequest>
  {
    private readonly IProductPriceService _productPriceService;
    // Application katman üzerin Domain layer tetiklediğimiz Katman
    // Aynı zamanda Farklı katmanlarada burada bağlanıp süreci yönetebiliriz.
    // Bu katmanda logic olmaz ilgili servisler sadece consume edilir.
   
    public ProductPriceChangeHandler(IProductPriceService productPriceService)
    {
      _productPriceService = productPriceService;
    }

    public Task Handle(PriceChangeProductRequest request, CancellationToken cancellationToken)
    {
      _productPriceService.UpdatePrice(request.Id, request.newPrice);

      return Task.CompletedTask;
    }

 
  }
}
