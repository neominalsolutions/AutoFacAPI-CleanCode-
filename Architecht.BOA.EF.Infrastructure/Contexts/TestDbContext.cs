using Architecht.BOA.EF.Infrastructure.Configurations;
using Architect.BOA.BLL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.BOA.EF.Infrastructure.Contexts
{
  public class TestDbContext:DbContext
  {
    //public TestDbContext(DbContextOptions<TestDbContext> opts):base(opts)
    //{

    //}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=DESKTOP-2V3N9MI\\SQLEXPRESS;Database=CleanCodeDB;Trusted_Connection=True; MultipleActiveResultSets=True;TrustServerCertificate=True;");
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      //modelBuilder.Entity<Product>().Property(x => x.Name).HasMaxLength(300);
      modelBuilder.ApplyConfiguration(new ProductConfig());

      base.OnModelCreating(modelBuilder);
    }

  }
}
