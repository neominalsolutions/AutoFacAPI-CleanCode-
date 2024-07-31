
using Architecht.Autofac.Aspect.Core;
using Architect.BOA.BLL.Services;
using Autofac;
using Autofac.Extras.DynamicProxy;

namespace Architect.BOA.BLL
{
  public class BussinessModule:Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<ProductPriceService>().As<IProductPriceService>().InstancePerLifetimeScope();

      builder.RegisterType<ProductService>().As<IProductService>().AsImplementedInterfaces().EnableInterfaceInterceptors().InterceptedBy(typeof(LogAspect), typeof(PerformanceAspect));
    }
  }
}