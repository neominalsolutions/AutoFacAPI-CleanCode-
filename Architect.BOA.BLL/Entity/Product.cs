using Architecht.Domain.Core;

namespace Architect.BOA.BLL
{

  public class Product:Entity
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public void PriceChange(decimal newPrice)
    {
      Price = newPrice;
    }

  }
}
