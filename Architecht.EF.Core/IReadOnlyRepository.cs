using Architecht.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.EF.Core
{
  // where TEntity: Entity Code Defensing yaptık 
  // Expression<Func<TEntity, bool>> prediciate LINQ kullanarak koşul yazmak için
  public interface IReadOnlyRepository<TEntity> where TEntity: Entity
    {
      TEntity FindById(Guid Id);
      IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> prediciate);
    }
}
