namespace Architect.BOA.BLL
{

  public class Product
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int Id { get; set; }

    public void PriceChange(decimal newPrice)
    {
      Price = newPrice;
    }

  }
}
