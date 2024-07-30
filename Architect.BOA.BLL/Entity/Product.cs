namespace Architect.BOA.BLL
{
  public record ProductPriceChangedArgs(int Id,decimal oldPrice,decimal newPrice);

  public class Product
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int Id { get; set; }

    public event EventHandler<ProductPriceChangedArgs> PriceChanged;

    public Product()
    {
      // Event Listener tanımı yaptık.
      // eventin çalışacağı method ataması yaptık
      //PriceChanged += Product_PriceChanged;
    }

    // Fiyat Değiştiği anda bu method tetiklenip içindeki kod çalışacak.
    // JS de callback benzeri bir yapı var.
    //private void Product_PriceChanged(object? sender, ProductPriceChangedArgs e)
    //{
    //  Console.WriteLine($"Ürünün fiyatı değişti : Eski Fiyat :{e.oldPrice}, Yeni Fiyat: {e.newPrice}");
    //}

    public void PriceChange(decimal newPrice)
    {
      var oldPrice = Price;
      Price = newPrice;

      //var @event = new ProductPriceChangedArgs(Id, oldPrice, newPrice);
      //PriceChanged.Invoke(this, @event);
    }

  }
}
