using Architecht.Autofac.Aspect.Core;
using Architecht.BOA.Application;
using Architecht.BOA.EF.Infrastructure;
using Architecht.BOA.EF.Infrastructure.Contexts;
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

// IoC container TestDbContext instance al dedik.
builder.Services.AddDbContext<TestDbContext>();

// Autofac IoC Container Tanýmý, Servis registeration iþlemi
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
  builder.RegisterModule(new AspectModule());
  builder.RegisterModule(new BussinessModule());
  builder.RegisterModule(new NotificationModule());
  builder.RegisterModule(new EFInfraModule());

});

// Application Module Net Core bazlý paketler kullandýðýndan dolayý Microsoft DI yönetmi ile yaptýk.
builder.Services.LoadApplicationServices();


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
