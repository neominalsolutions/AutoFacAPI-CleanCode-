using Architecht.BOA.EF.Infrastructure.Contexts;
using Architecht.EF.Core;
using Architect.BOA.BLL;
using Architect.BOA.BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.BOA.EF.Infrastructure.Repositories
{
  public class EFProductRepository : EFBaseRepository<TestDbContext, Product>, IProductRepository
  {
    public EFProductRepository(TestDbContext context) : base(context)
    {
    }
  }
}
