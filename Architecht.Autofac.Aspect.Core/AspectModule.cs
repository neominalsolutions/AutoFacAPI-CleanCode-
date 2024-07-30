using Autofac;

namespace Architecht.Autofac.Aspect.Core
{
  // Clean Code açısından Package Paketleme işlemleri yapacağımız zaman ilgili paket içerisindeki servisleri hizmetleri dışarıya IoC olarak hizmet verecek şekilde register eder bunları Modüler bir yapı olması için Module olarak tanımlarız.
  public class AspectModule: Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<LogAspect>();
      builder.RegisterType<PerformanceAspect>();
    }
  }
}