using Architect.BOA.BLL.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.BOA.Application
{
  public static class ApplicationModule
  {
    public static IServiceCollection LoadApplicationServices(this IServiceCollection services)
    {


      // Mediatora ait ne kadar Request Handler ne kadar Request tipi varsa hepsini uygulama register et. 
      services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

      services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

      services.AddFluentValidationAutoValidation();

      return services;
    }
  }
}
