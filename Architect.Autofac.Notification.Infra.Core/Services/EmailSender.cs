using Architect.Autofac.Notification.Infra.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architect.Autofac.Notification.Infra.Core
{
  public class EmailSender : ISender
  {
    private ILogger<EmailSender> _logger;

    public EmailSender(ILogger<EmailSender> logger)
    {
      _logger = logger;
    }
    public void Notify()
    {
      _logger.LogInformation("Email Notification gönderildi");

    }
  }
}
