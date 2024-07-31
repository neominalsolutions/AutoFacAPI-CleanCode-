using Architecht.Autofac.Aspect.Core;
using Architecht.BOA.Application;
using Architect.Autofac.Notification.Infra.Core;
using Architect.BOA.BLL;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Autofac IoC Container Tan�m�, Servis registeration i�lemi
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
  //builder.RegisterType<LogAspect>();
  //builder.RegisterType<PerformanceAspect>();

  // builder.RegisterType<ProductService>().As<IProductService>().AsImplementedInterfaces().EnableInterfaceInterceptors().InterceptedBy(typeof(LogAspect),typeof(PerformanceAspect));

  builder.RegisterModule(new AspectModule());
  builder.RegisterModule(new BussinessModule());
  builder.RegisterModule(new NotificationModule());

  // servis registeration ile birlikte servis bir aspect atamas� yapt�k.
  //builder.RegisterType<ProductService>().As<IProductService>().AsImplementedInterfaces().EnableInterfaceInterceptors().InterceptedBy(typeof(LogAspect),typeof(PerformanceAspect));

});

// Mediatora ait ne kadar Request Handler ne kadar Request tipi varsa hepsini uygulama register et. 
//builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<ProductPriceChangedHandler>());

// yeni versiyonda b�t�n validator nesnelerinin IoC y�klenmesi i�in kulland�k.


// builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
builder.Services.AddValidatorsFromAssemblyContaining<UpdateProductValidator>();
builder.Services.AddFluentValidationAutoValidation(); // Net Core API Validasyonlar� art�k bunun �zerindne �al��t�rs�n ayar�, Hata varsa 400 kodu d�nd�r�yor. hata yoksa kodumuz kald��� yerden devam ediyor. Bir method girmeden �nce otomatik olarak validation kontrol� yap�yor. 


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
