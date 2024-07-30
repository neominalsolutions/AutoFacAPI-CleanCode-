using Architecht.Autofac.Aspect.Core;
using AutoFacAPI.Features.Product.Dtos;
using MediatR;

namespace AutoFacAPI.Features.Product.Handlers
{
  public class ProductUpdateHandler : IRequestHandler<UpdateProductDto>
  {
    [Log]
    public Task Handle(UpdateProductDto request, CancellationToken cancellationToken)
    {
      //request.Name = "Ali"; Request değeri programcı yada code tarafında değiştirilmemlidir.


      // veri tabnaına update işlemi gerçekleşecek
      return Task.CompletedTask;
    }
  }
}
