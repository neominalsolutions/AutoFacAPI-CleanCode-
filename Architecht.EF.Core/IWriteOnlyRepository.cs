using Architecht.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.EF.Core
{
  public interface IWriteOnlyRepository<TEntity> where TEntity : Entity
  {
    void Insert(TEntity entity);
    void Delete(Guid Id);
    void Update(TEntity entity);
  }
}
