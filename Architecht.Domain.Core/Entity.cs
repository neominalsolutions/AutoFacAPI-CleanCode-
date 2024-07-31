using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Domain.Core
{
  public abstract class Entity
  {
    public Guid Id { get; init; }
    public DateTime CreatedAt { get; init; }

    public Entity()
    {
      Id = Guid.NewGuid();
      CreatedAt = DateTime.Now;
    }

  }
}
