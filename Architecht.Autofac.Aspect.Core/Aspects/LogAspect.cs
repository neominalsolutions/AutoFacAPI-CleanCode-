using Castle.DynamicProxy;
using Microsoft.Extensions.Logging;

namespace Architecht.Autofac.Aspect.Core
{
  /// <summary>
  /// Servislerin Request başlangıcı ile bitişi arasındaki Information Loglarını atmak için kullanılır.
  /// </summary>
  [AttributeUsage(AttributeTargets.Method)]
  public class LogAttribute: Attribute
  {

  }


  // Not: Aspectler tek başına kullanıdıklarında bir anlam ifade etmezler
  // bir servise çağırısına bağlanmalılar.
  public class LogAspect : IInterceptor
  {
    private ILogger<LogAspect> logger;

    public LogAspect(ILogger<LogAspect> logger)
    {
      this.logger = logger;
    }

    public void Intercept(IInvocation invocation)
    {
      // refrection kodu
      var method = invocation.MethodInvocationTarget ?? invocation.Method;
      var logAttributeExists = method.GetCustomAttributes(typeof(LogAttribute), true).Any();

      var service = invocation.TargetType;


      if (logAttributeExists)
      {

        var dataJson = System.Text.Json.JsonSerializer.Serialize(invocation.Arguments);

        this.logger.LogInformation($"Request Başladı: Request Body {dataJson} Çağırılan Method: {method.Name} Service Name: {service.Name}"); // Before

        invocation.Proceed(); // Before dan After'a geçiş

        this.logger.LogInformation("Request Bitti"); // After
      }
      else
      {
        invocation.Proceed(); // await next gibi yoluna devam et işlem yapma
      }
      

    }
  }
}
