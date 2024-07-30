using Architect.Autofac.Notification.Infra.Core;
using Autofac;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


// Api da kaynak tüketidiği için dünyada kabul görmüş api isimlendirme standartında controllerlar s takısı ile biter.

namespace AutoFacAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NotificationsController : ControllerBase
  {

    // Autofac de Keyed olarak bir interfaceden birden fazla service tanımı var Interface üzerinden hangi servisin çözümleneceğini bilemeyiz bu sebeple Autofac tarafı burada ILifetimeScope denilen özel bir servis çözümleme servisi yazmış.
    private readonly ILifetimeScope _lifetimeScope;

    public NotificationsController(ILifetimeScope lifetimeScope)
    {
      _lifetimeScope = lifetimeScope;
    }

    [HttpPost("/sms")]
    public IActionResult SendSms()
    {
      var notification = _lifetimeScope.ResolveKeyed<ISender>(SenderTypes.SMS);

      notification.Notify();

      return Ok();
    }

    [HttpPost("senderType/{notificationType}")]
    public IActionResult SendDynamicNotification(string notificationType)
    {
      if((notificationType == SenderTypes.Email) || (notificationType == SenderTypes.SMS) || (notificationType == SenderTypes.PushNotification))
      {
        var notification = _lifetimeScope.ResolveKeyed<ISender>(notificationType);

        notification.Notify();

        return Ok();
      }
      else
      {
        return BadRequest("Invalid Notification Type |sms|email|push-notification");
      }

      

    }


    [HttpPost("/email")]
    public IActionResult SendEmail()
    {
      var notification = _lifetimeScope.ResolveKeyed<ISender>(SenderTypes.Email);

      notification.Notify();

      return Ok();
    }

    [HttpPost("/pushNotification")]
    public IActionResult PushNotification()
    {
      var notification = _lifetimeScope.ResolveKeyed<ISender>(SenderTypes.PushNotification);

      notification.Notify();

      return Ok();
    }

  }
}
