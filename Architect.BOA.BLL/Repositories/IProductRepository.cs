using Architecht.EF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architect.BOA.BLL.Repositories
{
  /// <summary>
  /// Domain katmanına yada Bussiness katmanında dış katmanlardan bir giriş yapılacak ise port and adapter tasarım deseni kullanılır
  /// Buradaki interface yapıları bizim portlarımız oluyor
  /// Interfaceleri implemente eden diğer katmanlara ait classlar ise adapter oluypr
  /// EFProductRepository Adapter üzerinden çalıştırmak gibi
  /// </summary>
  public interface IProductRepository:IRepository<Product>
  {
  }
}
