using Architecht.Autofac.Aspect.Core;
using Architect.Autofac.Notification.Infra.Core;
using Architect.BOA.BLL;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Autofac IoC Container Tanýmý, Servis registeration iþlemi
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
  //builder.RegisterType<LogAspect>();
  //builder.RegisterType<PerformanceAspect>();

  // builder.RegisterType<ProductService>().As<IProductService>().AsImplementedInterfaces().EnableInterfaceInterceptors().InterceptedBy(typeof(LogAspect),typeof(PerformanceAspect));

  builder.RegisterModule(new AspectModule());
  builder.RegisterModule(new BussinessModule());
  builder.RegisterModule(new NotificationModule());

  // servis registeration ile birlikte servis bir aspect atamasý yaptýk.
  //builder.RegisterType<ProductService>().As<IProductService>().AsImplementedInterfaces().EnableInterfaceInterceptors().InterceptedBy(typeof(LogAspect),typeof(PerformanceAspect));

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
