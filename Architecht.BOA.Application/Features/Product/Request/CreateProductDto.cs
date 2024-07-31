using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Architecht.BOA.Application
{
  // Product Create den sorumlu bir Request
  public class CreateProductDto:IRequest
  {
    [Required(ErrorMessage = "Ürün ismi boş geçilemez")]
    public string? ProductName { get; set; }

    [Required(ErrorMessage = "Fiyat Boş Geçilemez")]
    public decimal? Price { get; set; }

    [Required(ErrorMessage = "Stok Boş geçilemez")]
    public int? Stock { get; set; }

  }
}
