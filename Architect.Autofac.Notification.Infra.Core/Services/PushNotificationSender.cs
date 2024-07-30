using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architect.Autofac.Notification.Infra.Core.Services
{
  public class PushNotificationSender : ISender
  {
    private readonly ILogger<PushNotificationSender> _logger;

    public PushNotificationSender(ILogger<PushNotificationSender> logger)
    {
      _logger = logger;
    }

    public void Notify()
    {
      _logger.LogInformation("Push Notification ile Bildirim atıldı");
    }
  }
}
