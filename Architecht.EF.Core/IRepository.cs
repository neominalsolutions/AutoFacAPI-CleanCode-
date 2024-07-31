using Architecht.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.EF.Core
{
  public interface IRepository<TEntity>:IReadOnlyRepository<TEntity>,IWriteOnlyRepository<TEntity> where TEntity:Entity
  {
  }
}
