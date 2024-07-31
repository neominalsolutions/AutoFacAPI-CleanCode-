
using FluentValidation;

namespace Architecht.BOA.Application
{
  // UpdateProductDto auto validation için net core bunu anlayıp otomatik validate etmesi için controller içindeki request edilen nesne ile validation yapılmalı, Request nesnesi programın application katmanındaki işleyişi için önemli.
  public class UpdateProductValidator:AbstractValidator<UpdateProductDto>
  {
    public UpdateProductValidator()
    {
      RuleFor(x => x.Name).NotEmpty().WithMessage("Name alanı boş geçilemez");
    }
  }
}
