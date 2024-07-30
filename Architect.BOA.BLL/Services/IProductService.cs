

namespace Architect.BOA.BLL
{

  public interface IProductService
  {
    void CreateProduct(Product product);

    void UpdateProduct(Product product);

    void DeleteProduct(int id);
  }
}
