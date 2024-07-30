using Architect.BOA.BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoFacAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductsController : ControllerBase
  {
    // ProductController üzerinden ProductService consume edilecek ise iki sınıf birbirine sıkı sıkıya bağlı olmaz DIP (Dependecy Inversion Principle)
    //  private readonly ProductService productService = new ProductService();
    // tight coupled
    private readonly IProductService _productService;

    // Dependency Injection Pattern => bir sınıfın instance bağımlılığını dışarıdan consturctor,method,setter yöntemi ile sınıfa tanımla. Direkt olarak instance alınmadığı için bağlımlıklar farklı yöntemlerle sınıfa dışarıdan enjecte edildiği için sınıflar arasındaki bağımlılık en az indirgenir.
    // Program Dosyasında Service Registeration işlemi yaptığımız için Developer instance almıyor bunun yerine Program kendi instance management yapıyor. Biz buna IoC (Inversion of Control) diyoruz.
    public ProductsController(IProductService productService)
    {
      _productService = productService;
    }

    [HttpPost]
    //[Authorize]
    public IActionResult Create([FromBody] Product model)
    {
      // kayıt yapılırken kayıt bağlangıcında ve kayıt sonunda loglamayı autofac üzerinden yaptıracağız.
      _productService.CreateProduct(model);

      return Ok();
    }


  }
}
