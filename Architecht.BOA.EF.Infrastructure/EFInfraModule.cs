using Architecht.BOA.EF.Infrastructure.Repositories;
using Architect.BOA.BLL.Repositories;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.BOA.EF.Infrastructure
{
  public class EFInfraModule:Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<EFProductRepository>().As<IProductRepository>().InstancePerLifetimeScope();

    }

  }
}
