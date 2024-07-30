using Castle.DynamicProxy;
using System.Diagnostics;

namespace Architecht.Autofac.Aspect.Core
{
  [AttributeUsage(AttributeTargets.Method)]
  public class PerformanceAttribute:Attribute
  {

  }

  public class PerformanceAspect : IInterceptor
  {
    private Stopwatch stopWatch;

    public PerformanceAspect()
    {
      stopWatch = new Stopwatch();
    }

    public void Intercept(IInvocation invocation)
    {

      var method = invocation.MethodInvocationTarget ?? invocation.Method;
      var attributeExists = method.GetCustomAttributes(typeof(PerformanceAttribute), true).Any();

      if(attributeExists)
      {
        stopWatch.Start();
        Console.WriteLine($"Start Time" + stopWatch.ElapsedMilliseconds);

        invocation.Proceed();

        stopWatch.Stop();
        Console.WriteLine($"Stop Time" + stopWatch.ElapsedMilliseconds);
      } 
      else
      {
        invocation.Proceed();
      }
     
    }
  }
}
