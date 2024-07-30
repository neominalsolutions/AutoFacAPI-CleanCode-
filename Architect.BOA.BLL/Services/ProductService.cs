

using Architecht.Autofac.Aspect.Core;

namespace Architect.BOA.BLL
{
  public class ProductService : IProductService
  {
    [Log]
    [Performance]
    public void CreateProduct(Product product)
    {
      Console.WriteLine($"Ürün Kaydedildi");
    }
  }
}
