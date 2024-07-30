using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architect.Autofac.Notification.Infra.Core
{
  // Open Closed ile INotification dan türeyecek bir çok sınıf yapıp birbirinden izeol bir şekilde logiclerini yazabiliriz. Kodda değişiklik yapmadan Notification sınıfına yeni davranış özellikleri kazandırabiliriz.
  public interface ISender
  {
    void Notify();
  }
}
