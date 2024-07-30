using AutoFacAPI.Features.Product.Dtos;
using FluentValidation;

namespace AutoFacAPI.Features.Product.Validators
{
  public class UpdateProductValidator:AbstractValidator<UpdateProductDto>
  {
    public UpdateProductValidator()
    {
      RuleFor(x => x.Name).NotEmpty().WithMessage("Name alanı boş geçilemez");
    }
  }
}
