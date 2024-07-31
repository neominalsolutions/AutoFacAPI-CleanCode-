using Architecht.Autofac.Aspect.Core;
using Architecht.BOA.Application;
using MediatR;

namespace AutoFacAPI.Features.Product.Handlers
{
  public class ProductUpdateHandler : IRequestHandler<UpdateProductRequest>
  {
    [Log]
    public Task Handle(UpdateProductRequest request, CancellationToken cancellationToken)
    {
      //request.Name = "Ali"; Request değeri programcı yada code tarafında değiştirilmemlidir.

     

      // veri tabnaına update işlemi gerçekleşecek
      return Task.CompletedTask;
    }
  }
}
