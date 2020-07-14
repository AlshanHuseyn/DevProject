using DevProject.DTO.DTOs.SignDtos;
using FluentValidation;

namespace DevProject.Business.ValidationRules.FluentValidation
{
    public class SignUpValidator : AbstractValidator<SignUpDto>
    {
        public SignUpValidator()
        {
            RuleFor(m => m.Username).NotNull().WithMessage("Zəhmət olmasa, İstifadəçi Adı bölməsini doldurun");

            RuleFor(m => m.Password).NotNull().WithMessage("Zəhmət olmasa,Şifrə bölməsini doldurun");

            RuleFor(m => m.ConfirmPassword).NotNull().WithMessage("Zəhmət olmasa,Şifrənizi təsdiqləyin bölməsini doldurun");

            RuleFor(m => m.ConfirmPassword).Equal(m => m.Password).WithMessage("Zəhmət olmasa,Şifrənizi təkrar edin");

            RuleFor(m => m.Email).NotNull().WithMessage("Zəhmət olmasa,Email bölməsini doldurun")
                .EmailAddress().WithMessage("Zəhmət olmasa,Doğru Email daxil edin");

            RuleFor(m => m.Name).NotNull().WithMessage("Zəhmət olmasa,Adınız bölməsini doldurun");

            RuleFor(m => m.Surname).NotNull().WithMessage("Zəhmət olmasa,Soyadınız bölməsini doldurun");

            RuleFor(m => m.Age).NotNull().WithMessage("Zəhmət olmasa,Yaşiniz bölməsini doldurun");
        }
    }
}
