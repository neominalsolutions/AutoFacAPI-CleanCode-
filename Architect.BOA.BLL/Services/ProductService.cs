

using Architecht.Autofac.Aspect.Core;

namespace Architect.BOA.BLL
{
  public class ProductService : IProductService
  {
    

    [Log]
    [Performance]
    public void CreateProduct(Product product)
    {
      // Data Access Layer çağırarak veri tabanı kayıt işlemleri
      Console.WriteLine($"Ürün Kaydedildi");
    }

    public void DeleteProduct(int id)
    {
      Console.WriteLine($"Ürün Silindi");
    }

    public void UpdateProduct(Product product)
    {
      Console.WriteLine($"Ürün Güncellendi");
    }
  }
}
