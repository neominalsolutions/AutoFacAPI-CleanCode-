using Architect.Autofac.Notification.Infra.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architect.Autofac.Notification.Infra.Core
{
  public class SmsSender : ISender
  {
    private readonly ILogger<SmsSender> _logger;

    public SmsSender(ILogger<SmsSender> logger)
    {
      _logger = logger;
    }
    public void Notify()
    {
      _logger.LogInformation("SMS ile Bildirim atıldı");
    }
  }
}
