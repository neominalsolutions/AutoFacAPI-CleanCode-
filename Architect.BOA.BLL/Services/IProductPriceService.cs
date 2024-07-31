using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architect.BOA.BLL.Services
{
  public interface IProductPriceService
  {
    void UpdatePrice(Guid Id, decimal newPrice);
  }
}
