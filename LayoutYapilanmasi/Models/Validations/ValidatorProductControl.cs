using Microsoft.AspNetCore;
using FluentValidation;
using FluentValidation.AspNetCore;
using LayoutYapilanmasi.Models.Products;

namespace LayoutYapilanmasi.Models.Validations
{
    public class ValidatorProductControl : AbstractValidator<ProductControl>
    {
        public ValidatorProductControl()
        {
            RuleFor(x => x.email).NotEmpty().WithMessage("Lütfen emaili girin");
            RuleFor(x => x.email).NotNull().WithMessage("Lütfen emaili girin");
            RuleFor(x => x.email).EmailAddress().WithMessage("Lütfen email tipte girin");
            RuleFor(x => x.ad).NotEmpty().WithMessage("Lütfen adı giriniz");
            RuleFor(x => x.ad).NotNull().WithMessage("Lütfen adı giriniz");
            RuleFor(x => x.ad).MaximumLength(50).WithMessage("lütfen 50 karakterden az giriniz");
            RuleFor(x => x.soyad).NotEmpty().WithMessage("Lütfen soyadı giriniz");
            RuleFor(x => x.soyad).NotNull().WithMessage("Lütfen soyadı giriniz");
            RuleFor(x => x.soyad).MaximumLength(50).WithMessage("Lütfen 50 karakterden az giriniz");
        }
    }
}
