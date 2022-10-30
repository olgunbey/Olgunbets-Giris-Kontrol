using FluentValidation;
using LayoutYapilanmasi.Models.Products;

namespace LayoutYapilanmasi.Models.Validations
{
    public class ValidatorProduct:AbstractValidator<Product>
    {
        public ValidatorProduct()
        {
            RuleFor(x => x.ad).NotEmpty().WithMessage("Lütfen adı boş geçmeyin");
            RuleFor(x => x.ad).NotNull().WithMessage("Lütfen adı boş geçmeyin");
            RuleFor(x => x.ad).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla girmeyin");
            RuleFor(x => x.soyad).NotNull().WithMessage("Lütfen boş geçmeyin");
            RuleFor(x => x.soyad).NotEmpty().WithMessage("Lütfen boş geçmeyin");
            RuleFor(x => x.soyad).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla girmeyin");
            RuleFor(x => x.email).EmailAddress().WithMessage("lütfen emaili doğru giriniz");
            RuleFor(x => x.email).NotEmpty().WithMessage("Lütfen emaili boş geçmeyin");
            RuleFor(x => x.email).NotNull().WithMessage("Lütfen emaili boş geçmeyin");
        }
    }
}
