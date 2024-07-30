using AutoFacAPI.Features.Product.Dtos;
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
      // veri tabanı kayıt yada bussiness logic layerdaki servis çağırıları burada gerçekleşebilir.
      // uygulama içerisinde gelen create isteklerini işlediğimiz yer.
      _logger.LogInformation("Ürün Kayıt işlemi");

      return Task.CompletedTask;
    }
  }
}
