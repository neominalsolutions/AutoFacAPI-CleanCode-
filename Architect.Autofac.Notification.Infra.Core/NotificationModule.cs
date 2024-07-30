using Architect.Autofac.Notification.Infra.Core.Services;
using Autofac;

namespace Architect.Autofac.Notification.Infra.Core
{
  public class NotificationModule:Module
  {

    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<EmailSender>().Keyed<ISender>(SenderTypes.Email);
      builder.RegisterType<SmsSender>().Keyed<ISender>(SenderTypes.SMS);
      builder.RegisterType<PushNotificationSender>().Keyed<ISender>(SenderTypes.PushNotification);
    }

  }
}