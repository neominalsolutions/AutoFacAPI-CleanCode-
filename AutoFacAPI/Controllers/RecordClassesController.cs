using AutoFacAPI.ValueObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoFacAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RecordClassesController : ControllerBase
  {
    [HttpGet]
    public IActionResult Get()
    {
      var m1 = new Money(10, "$");
      var m2 = new Money(20, "$");
      var m3 = new Money(10, "$");

      if (m1.Equals(m3))
      {
        // true
      }
     
      if (m2.Equals(m3))
      {
        // false
      }

      //var mc1 = new MoneyClass { Amount = 20, Currency = "$" };
      //var mc2 = new MoneyClass { Amount = 20, Currency = "$" };

      var mc1 = new MoneyClass(20,"$");
      // mc1.Amount = 12;
      var mc2 = new MoneyClass(20, "$");

      if (mc1.Equals(mc2)) // class değere bakmaz referansa bakar.
      {
        // false
      }

      return Ok();
    }
  }
}
