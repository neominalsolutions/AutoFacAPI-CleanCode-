
using AutoFacAPI.Features.Product.Request;
using MediatR;

namespace AutoFacAPI.Features.Product.Handlers
{
  public class ProductCreateHandler : IRequestHandler<CreateProductDto>
  {
    private readonly ILogger<ProductCreateHandler> _logger;

    public ProductCreateHandler(ILogger<ProductCreateHandler> logger)
    {
      _logger = logger;
    }

    public Task Handle(CreateProductDto request, CancellationToken cancellationToken)
    {

      //request.Price = 15; class olduğu için mutuable tanımlandı bu durumda developer tarafında değeri değiştirilebildi.

      // veri tabanı kayıt yada bussiness logic layerdaki servis çağırıları burada gerçekleşebilir.
      // uygulama içerisinde gelen create isteklerini işlediğimiz yer.
      _logger.LogInformation("Ürün Kayıt işlemi");

      return Task.CompletedTask;
    }
  }
}
