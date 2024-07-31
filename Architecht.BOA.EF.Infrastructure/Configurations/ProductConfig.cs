using Architect.BOA.BLL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.BOA.EF.Infrastructure.Configurations
{
  public class ProductConfig : IEntityTypeConfiguration<Product>
  {
    public void Configure(EntityTypeBuilder<Product> builder)
    {
      builder.Property(x => x.Name).HasMaxLength(300);

      
    }
  }
}
