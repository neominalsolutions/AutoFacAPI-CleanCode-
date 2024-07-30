using AutoFacAPI.Features.Product.Dtos;
using AutoFacAPI.Features.Product.Request;
using FluentValidation;

namespace AutoFacAPI.Features.Product.Validators
{
  public class UpdateProductValidator:AbstractValidator<UpdateProductRequest>
  {
    public UpdateProductValidator()
    {
      RuleFor(x => x.Name).NotEmpty().WithMessage("Name alanı boş geçilemez");
    }
  }
}
