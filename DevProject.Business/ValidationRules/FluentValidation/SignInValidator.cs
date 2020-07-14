using DevProject.DTO.DTOs.SignDtos;
using FluentValidation;

namespace DevProject.Business.ValidationRules.FluentValidation
{
    public class SignInValidator : AbstractValidator<SignInDto>
    {
        public SignInValidator()
        {
            RuleFor(m => m.Username).NotNull().WithMessage("Zəhmət olmasa, İstifadəçi Adı bölməsini doldurun");

            RuleFor(m => m.Password).NotNull().WithMessage("Zəhmət olmasa,Şifrə bölməsini doldurun");
        }
    }
}
